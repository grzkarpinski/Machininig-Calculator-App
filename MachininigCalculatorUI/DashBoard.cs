using MachininigCalculatorLibary;

namespace MachininigCalculatorUI;

public partial class DashBoard : Form
{
    public DashBoard()
    {
        InitializeComponent();
    }

    private async void calculateBasicParametersButton_Click(object sender, EventArgs e)
    {
        //validate input

        try
        {
            systemStatus.Text = "Calculating...";
            if (radioButtonMilling.Checked)
            {
                systemStatus.Text = "Milling";
                ToolMilling tool = new ToolMilling();

                //calculate revolutions
                tool.toolDiameter = readNumberFromUI.readIntNumber(DinputBox.Text);
                tool.cuttingSpeed = readNumberFromUI.readIntNumber(vcInputBox.Text);
                tool.CalculateRevolutionsPerMinute(tool.cuttingSpeed, tool.toolDiameter);
                revolutionsOutputBox.Text = tool.revolutions.ToString();
                //calculate feed
                tool.numberOfTeeth = readNumberFromUI.readIntNumber(zInputBox.Text);
                tool.feedRatePerTooth = readNumberFromUI.readDoubleNumber(fzInputBox.Text);

                tool.CalculateFeedPerMinuteMilling(tool.feedRatePerTooth, tool.numberOfTeeth, tool.revolutions);
                feedOutputBox.Text = tool.feedPerMinuteMilling.ToString();
            }
            else if (radioButtonDrilling.Checked)
            {
                systemStatus.Text = "Drilling";
                ToolDrilling tool = new ToolDrilling();

                //calculate revolutions
                tool.toolDiameter = readNumberFromUI.readIntNumber(DinputBox.Text);
                tool.cuttingSpeed = readNumberFromUI.readIntNumber(vcInputBox.Text);
                tool.CalculateRevolutionsPerMinute(tool.cuttingSpeed, tool.toolDiameter);
                revolutionsOutputBox.Text = tool.revolutions.ToString();
                //calculate feed
                tool.feedRatePerRevolution = readNumberFromUI.readDoubleNumber(fnInputBox.Text);
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

    private void vcInputBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void revolutionsOutputBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void DashBoard_Load(object sender, EventArgs e)
    {

    }
}
