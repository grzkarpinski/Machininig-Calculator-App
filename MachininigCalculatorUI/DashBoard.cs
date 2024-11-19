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
        try
        {

            if (radioButtonMilling.Checked)
            {
                systemStatus.Text = "Milling";
                _millingTool = new ToolMilling();

                ReadMillingParametersFromUI(_millingTool);

                _millingTool.CalculateRevolutionsPerMinute(_millingTool.CuttingSpeed, _millingTool.ToolDiameter);
                revolutionsOutputBox.Text = _millingTool.Revolutions.ToString();

                _millingTool.CalculateFeedPerMinuteMilling(_millingTool.FeedRatePerTooth, _millingTool.NumberOfTeeth, _millingTool.Revolutions);
                feedOutputBox.Text = _millingTool.FeedPerMinuteMilling.ToString();

                systemStatus.Text = "S and F calculated!";
            }
            else if (radioButtonDrilling.Checked)
            {
                systemStatus.Text = "Drilling";
                ToolDrilling tool = new ToolDrilling();

                ReadDrillingParametersFromUI(tool);

                tool.CalculateRevolutionsPerMinute(tool.CuttingSpeed, tool.ToolDiameter);
                revolutionsOutputBox.Text = tool.Revolutions.ToString();

                tool.CalculateFeedPerMinuteDrilling(tool.FeedRatePerRevolution, tool.Revolutions);
                feedOutputBox.Text = tool.FeedPerMinuteDrilling.ToString();

                systemStatus.Text = "S and F calculated!";
            }
            else
            {
                systemStatus.Text = "Select a machining type";
            }

        }
        catch (Exception ex)
        {
            systemStatus.Text = $"Error in calculating S and F: {ex.Message}";
        }
    }

    private void calculateVolumetricCuttingEfficiencyButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (radioButtonMilling.Checked && feedOutputBox.Text != "")
            {
                ReadVolumetricParametersFromUi(_millingTool);
                _millingTool.CalculateVolmetricEfficency(_millingTool.FeedPerMinuteMilling, _millingTool.MillingWidth, _millingTool.MillingDepth);
                qOutputBox.Text = _millingTool.VolmetricEfficency.ToString();

                systemStatus.Text = "Q calculated!";
            }
            else
            {
                systemStatus.Text = "Calculate basic milling parameters first";
            }
        }
        catch (Exception ex)
        {
            systemStatus.Text = $"Error in calculating Q: {ex.Message}";
        }

    }

    public void ReadMillingParametersFromUI(ToolMilling tool)
    {
        try
        {
            tool.ToolDiameter = ReadNumberFromUI.ReadDoubleNumber(DinputBox.Text);
            tool.CuttingSpeed = ReadNumberFromUI.ReadIntNumber(vcInputBox.Text);
            tool.NumberOfTeeth = ReadNumberFromUI.ReadIntNumber(zInputBox.Text);
            tool.FeedRatePerTooth = ReadNumberFromUI.ReadDoubleNumber(fzInputBox.Text);
        }
        catch (Exception ex)
        {
            systemStatus.Text = $"Error: {ex.Message}";
            throw;
        }
    }

    public void ReadDrillingParametersFromUI(ToolDrilling tool)
    {
        try
        {
            tool.ToolDiameter = ReadNumberFromUI.ReadDoubleNumber(DinputBox.Text);
            tool.CuttingSpeed = ReadNumberFromUI.ReadIntNumber(vcInputBox.Text);
            tool.FeedRatePerRevolution = ReadNumberFromUI.ReadDoubleNumber(fnInputBox.Text);
        }
        catch (Exception ex)
        {
            systemStatus.Text = $"Error: {ex.Message}";
            throw;
        }
    }

    public void ReadVolumetricParametersFromUi(ToolMilling tool)
    {
        try
        {
            tool.MillingDepth = ReadNumberFromUI.ReadDoubleNumber(apInputBox.Text);
            tool.MillingWidth = ReadNumberFromUI.ReadDoubleNumber(aeInputBox.Text);
        }
        catch (Exception ex)
        {
            systemStatus.Text = $"Error: {ex.Message}";
            throw;
        }
    }

    private void RadioButton_CheckedChanged(object sender, EventArgs e)
    {
        if (radioButtonMilling.Checked)
        {
            fnInputBox.ReadOnly = true;
            fzInputBox.ReadOnly = false;
            zInputBox.ReadOnly = false;
            apInputBox.ReadOnly = false;
            aeInputBox.ReadOnly = false;
        }
        else if (radioButtonDrilling.Checked)
        {
            fnInputBox.ReadOnly = false;
            fzInputBox.ReadOnly = true;
            zInputBox.ReadOnly = true;
            apInputBox.ReadOnly = true;
            aeInputBox.ReadOnly = true;
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
