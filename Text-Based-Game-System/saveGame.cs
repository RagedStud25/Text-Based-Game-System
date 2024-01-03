using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Text_Based_Game_System;

namespace Text_Based_Game_System
{
    public partial class frmSave : Form
    {
        private TextBox textBoxForInput = new TextBox();
        private Label currentLabel; // Keep track of the currently clicked label
        public int PlayerID { get; set; }
        private DatabaseHelper databaseHelper;
        public frmSave()
        {
            InitializeComponent();
            InitializeTextBox();

            // Initialize DatabaseHelper instance
            databaseHelper = new DatabaseHelper();

            // Initialize for each label and textbox
            InitializeLabelAndTextBox(lblFirstSaveSlot, tbSlotOne);
            InitializeLabelAndTextBox(lblSecondSaveSlot, tbSlotTwo);
            InitializeLabelAndTextBox(lblThirdSaveSlot, tbSlotThree);
        }

        private void InitializeLabelAndTextBox(Label label, TextBox textBox)
        {
            label.MouseClick += GenericLabel_MouseClick;
            HideTextBoxAndResetLabel(label, textBox);
        }

        private void InitializeTextBox()
        {
            // Set properties for textBoxForInput
            textBoxForInput.Visible = false;
            textBoxForInput.LostFocus += TextBoxForInput_LostFocus;
            textBoxForInput.TextChanged += TextBoxForInput_TextChanged;
            textBoxForInput.KeyDown += TextBoxForInput_KeyDown;
            Controls.Add(textBoxForInput);

            // Handle the form's MouseDown event to reset the label highlight and hide the textbox
            this.MouseDown += FrmSave_MouseDown;
        }
        private void SaveGameProgressCommon(string saveSlot, string saveData)
        {
            int playerId = (this.Owner as mainGameScreen)?.latestPlayerId ?? 0;

            if (playerId != 0)
            {
                // Extract numeric part from the end of the saveSlot parameter
                string numericPart = new string(saveSlot.Where(char.IsDigit).ToArray());

                // Convert numeric part to integer
                if (int.TryParse(numericPart, out int saveSlotInt))
                {
                    Console.WriteLine($"saveSlotInt: {saveSlotInt}"); // Debugging

                    try
                    {
                        bool saveResult = databaseHelper.SavePlayerProgress(playerId, saveData, saveSlotInt);

                        if (saveResult)
                        {
                            MessageBox.Show("Game progress saved successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to save game progress.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"SQL Exception: {ex.Message}");
                        // Log the exception or handle it accordingly
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving game progress: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show($"Invalid save slot: {numericPart}");
                }
            }
            else
            {
                MessageBox.Show("Invalid player ID.");
            }
        }

        private void TextBoxForInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetTextBoxForLabel(currentLabel).Text = currentLabel.Text = GetTextBoxForLabel(currentLabel).Text.Trim();
                GetTextBoxForLabel(currentLabel).Visible = false;
                currentLabel.BorderStyle = BorderStyle.None;

                SaveGameProgressCommon(currentLabel.Text, currentLabel.Name.Substring(15));
            }
        }

        private void FrmSave_MouseDown(object sender, MouseEventArgs e)
        {
            // Reset label highlight and hide the textbox for the previously clicked label
            if (currentLabel != null)
            {
                currentLabel.BorderStyle = BorderStyle.None;
                HideTextBoxAndResetLabel(currentLabel, GetTextBoxForLabel(currentLabel));
                currentLabel = null; // Reset the currently clicked label
            }
        }

        private void GenericLabel_MouseClick(object sender, MouseEventArgs e)
        {
            Label clickedLabel = (Label)sender;

            // Reset label highlight and hide the textbox for the previously clicked label
            if (currentLabel != null)
            {
                currentLabel.BorderStyle = BorderStyle.None;
                HideTextBoxAndResetLabel(currentLabel, GetTextBoxForLabel(currentLabel));
                currentLabel = null; // Reset the currently clicked label
            }

            // Show TextBox for the newly clicked label
            ShowTextBoxForLabel(clickedLabel, GetTextBoxForLabel(clickedLabel));

            // Set focus on the form to ensure it receives MouseDown event
            this.Focus();
        }

        private void ShowTextBoxForLabel(Label label, TextBox textBox)
        {
            // Show TextBox for input when label is clicked
            currentLabel = label;
            currentLabel.BorderStyle = BorderStyle.FixedSingle;
            textBox.Text = label.Text;
            textBox.Visible = true;
            textBox.Focus();
            textBox.SelectAll();
        }

        private void TextBoxForInput_LostFocus(object sender, EventArgs e)
        {
            // Hide TextBox when it loses focus
            if (currentLabel != null)
            {
                GetTextBoxForLabel(currentLabel).Visible = false;
                currentLabel.BorderStyle = BorderStyle.None;
            }
        }

        private void TextBoxForInput_TextChanged(object sender, EventArgs e)
        {
            // Update the label text when text in TextBox changes
            currentLabel.Text = GetTextBoxForLabel(currentLabel).Text;
        }

        private TextBox GetTextBoxForLabel(Label label)
        {
            // Returns the TextBox associated with the given label
            switch (label.Name)
            {
                case "lblFirstSaveSlot":
                    return tbSlotOne;
                case "lblSecondSaveSlot":
                    return tbSlotTwo;
                case "lblThirdSaveSlot":
                    return tbSlotThree;
                default:
                    return null;
            }
        }

        private void HideTextBoxAndResetLabel(Label label, TextBox textBox)
        {
            // Hide the TextBox and reset the label
            textBox.Visible = false;
            label.BorderStyle = BorderStyle.None;
        }

        private void SaveGameProgress(string saveSlot, string saveData)
        {
            int playerId = (this.Owner as mainGameScreen)?.latestPlayerId ?? 0;

            if (playerId != 0)
            {
                // Extract numeric part from the end of the saveSlot parameter
                string numericPart = new string(saveSlot.Where(char.IsDigit).ToArray());

                // Convert numeric part to integer
                if (int.TryParse(numericPart, out int saveSlotInt))
                {
                    Console.WriteLine($"saveSlotInt: {saveSlotInt}"); // Debugging

                    DatabaseHelper databaseHelper = new DatabaseHelper();
                    bool saveResult = databaseHelper.SavePlayerProgress(playerId, saveData, saveSlotInt);

                    if (saveResult)
                    {
                        MessageBox.Show("Game progress saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save game progress.");
                    }
                }
                else
                {
                    MessageBox.Show($"Invalid save slot: {numericPart}");
                }
            }
            else
            {
                MessageBox.Show("Invalid player ID.");
            }
        }

        private void btnSaveYourGame_Click(object sender, EventArgs e)
        {
            if (currentLabel != null && GetTextBoxForLabel(currentLabel).Visible)
            {
                GetTextBoxForLabel(currentLabel).Text = currentLabel.Text = GetTextBoxForLabel(currentLabel).Text.Trim();

                GetTextBoxForLabel(currentLabel).Visible = false;
                currentLabel.BorderStyle = BorderStyle.None;

                SaveGameProgressCommon(GetTextBoxForLabel(currentLabel).Text, currentLabel.Name.Substring(15));

                currentLabel = null;
                this.Close();
            }
        }
    }
}
