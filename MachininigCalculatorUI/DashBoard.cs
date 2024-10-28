using MachininigCalculatorLibary;

namespace MachininigCalculatorUI;

public partial class DashBoard : Form
{
    private ToolMilling _millingTool;

    public DashBoard()
    {
        InitializeComponent();
        radioButtonMilling.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        radioButtonDrilling.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
    }

    private void calculateBasicParametersButton_Click(object sender, EventArgs e)
    {
        //validate input

        try
        {
            systemStatus.Text = "Calculating...";

            if (radioButtonMilling.Checked)
            {
                systemStatus.Text = "Milling";
                _millingTool = new ToolMilling();

                ReadMillingParametersFromUI(_millingTool);

                _millingTool.CalculateRevolutionsPerMinute(_millingTool.cuttingSpeed, _millingTool.toolDiameter);
                revolutionsOutputBox.Text = _millingTool.revolutions.ToString();

                _millingTool.CalculateFeedPerMinuteMilling(_millingTool.feedRatePerTooth, _millingTool.numberOfTeeth, _millingTool.revolutions);
                feedOutputBox.Text = _millingTool.feedPerMinuteMilling.ToString();
            }
            else if (radioButtonDrilling.Checked)
            {
                systemStatus.Text = "Drilling";
                ToolDrilling tool = new ToolDrilling();

                ReadDrillingParametersFromUI(tool);

                tool.CalculateRevolutionsPerMinute(tool.cuttingSpeed, tool.toolDiameter);
                revolutionsOutputBox.Text = tool.revolutions.ToString();

                tool.CalculateFeedPerMinuteDrilling(tool.feedRatePerRevolution, tool.revolutions);
                feedOutputBox.Text = tool.feedPerMinuteDrilling.ToString();
            }

            systemStatus.Text = "Done";
        }
        catch (Exception ex)
        {
            systemStatus.Text = "Error";
        }
    }

    private void calculateVolumetricCuttingEfficiencyButton_Click(object sender, EventArgs e)
    {
        if (radioButtonMilling.Checked && feedOutputBox.Text != "")
        {
            ReadVolumetricParametersFromUi(_millingTool);
            _millingTool.CalculateVolmetricEfficency(_millingTool.feedPerMinuteMilling, _millingTool.millingWidth, _millingTool.millingDepth);
            qOutputBox.Text = _millingTool.volmetricEfficency.ToString();

            systemStatus.Text = "Q calculated!";
        }
        else
        {
            systemStatus.Text = "Calculate basic milling parameters first";
        }

    }

    public void ReadMillingParametersFromUI(ToolMilling tool)
    {
        tool.toolDiameter = ReadNumberFromUI.readIntNumber(DinputBox.Text);
        tool.cuttingSpeed = ReadNumberFromUI.readIntNumber(vcInputBox.Text);
        tool.numberOfTeeth = ReadNumberFromUI.readIntNumber(zInputBox.Text);
        tool.feedRatePerTooth = ReadNumberFromUI.readDoubleNumber(fzInputBox.Text);
    }

    public void ReadDrillingParametersFromUI(ToolDrilling tool)
    {
        tool.toolDiameter = ReadNumberFromUI.readIntNumber(DinputBox.Text);
        tool.cuttingSpeed = ReadNumberFromUI.readIntNumber(vcInputBox.Text);
        tool.feedRatePerRevolution = ReadNumberFromUI.readDoubleNumber(fnInputBox.Text);
    }

    public void ReadVolumetricParametersFromUi(ToolMilling tool)
    {
        tool.millingDepth = ReadNumberFromUI.readDoubleNumber(apInputBox.Text);
        tool.millingWidth = ReadNumberFromUI.readDoubleNumber(aeInputBox.Text);
    }

    private void RadioButton_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButtonMilling.Checked)
        {
            fnInputBox.ReadOnly = true;
            fzInputBox.ReadOnly = false;
        }
        else if (radioButtonDrilling.Checked)
        {
            fnInputBox.ReadOnly = false;
            fzInputBox.ReadOnly = true;
        }
    }

    private void vcInputBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void revolutionsOutputBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void DashBoard_Load(object sender, EventArgs e)
    {

    }

    private void clearButton_Click(object sender, EventArgs e)
    {
        clearAllFields();
    }

    private void clearAllFields()
    {
        DinputBox.Text = "";
        vcInputBox.Text = "";
        zInputBox.Text = "";
        fzInputBox.Text = "";
        fnInputBox.Text = "";
        apInputBox.Text = "";
        aeInputBox.Text = "";
        revolutionsOutputBox.Text = "";
        feedOutputBox.Text = "";
        qOutputBox.Text = "";
    }
}
