using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDevelopment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\solis\OneDrive\Documents\PRODUCTION.mdb";

            // Create a connection.
            OleDbConnection connection = new OleDbConnection(connectionString);
            string sql = @"
                INSERT INTO BOMHeaderFile (BOMHDATE, BOMHNO, BOMHJONO, BOMHPRODCODE, BOMHPREPBY, BOMHAPPBY)
                VALUES (@Date, @BOMNo, @JONo, @ProductCode, @PreparedByCode, @ApprovedByCode);

                INSERT INTO BOMDetailFile (BOMDNO, BOMDMATCODE, BOMDQTYNEED, BOMDTOTQTYNEED)
                VALUES (@BOMNo, @MaterialCode, @QuantityNeeded, @TotalQuantityNeeded);

            ";
            // Create a command.
            DateTime date = DateTime.Now;
            int bomNo = int.Parse(txtBOMNo.Text);
            int joNo = int.Parse(txtJONo.Text);
            string productCode = txtProductCode.Text;
            string preparedByCode = txtPreparedByCode.Text;
            string approvedByCode = txtApprovedByCode.Text;
            string materialCode = txtMaterialCode.Text;
            string materialDescription = txtMaterialDescription.Text;
            string unitOfMeasure = txtUnitOfMeasure.Text;
            int quantityNeeded = int.Parse(txtQuantityNeeded.Text);
            int totalQuantityNeeded = int.Parse(txtTotalQuantityNeeded.Text);

            OleDbCommand command = new OleDbCommand(sql, connection);
            try
            {
                // Execute the command.
                connection.Open();
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@BOMNo", bomNo);
                command.Parameters.AddWithValue("@JONo", joNo);
                command.Parameters.AddWithValue("@ProductCode", productCode);
                command.Parameters.AddWithValue("@PreparedByCode", preparedByCode);
                command.Parameters.AddWithValue("@ApprovedByCode", approvedByCode);
                command.Parameters.AddWithValue("@MaterialCode", materialCode);
                command.Parameters.AddWithValue("@MaterialDescription", materialDescription);
                command.Parameters.AddWithValue("@UnitOfMeasure", unitOfMeasure);
                command.Parameters.AddWithValue("@QuantityNeeded", quantityNeeded);
                command.Parameters.AddWithValue("@TotalQuantityNeeded", totalQuantityNeeded);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                // Close the connection.
                connection.Close();
            }

            // Display a message to indicate that the data was saved successfully.
            MessageBox.Show("Data saved successfully.");
            ClearTextBoxes(txtBOMNo);
            ClearTextBoxes(txtJONo);
            ClearTextBoxes(txtProductCode);
            ClearTextBoxes(txtPreparedByCode);
            ClearTextBoxes(txtApprovedByCode);
            ClearTextBoxes(txtMaterialCode);
            ClearTextBoxes(txtMaterialDescription);
            ClearTextBoxes(txtUnitOfMeasure);
            ClearTextBoxes(txtQuantityNeeded);
            ClearTextBoxes(txtTotalQuantityNeeded);
            ClearTextBoxes(txtBOMQtyOrd);
            ClearTextBoxes(txtBoMDescription);

        }
        public static void ClearTextBoxes(TextBox textBox)
        {
            textBox.Text = "";
        }
    }
}
