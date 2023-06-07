using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace SucuriNaturaleWindowsFormsApplication
{
    public partial class SucuriNaturaleMasterDetailForm : Form
    {
        string connectionString = @"Server=LEGIONOFCRISTI\SQLEXPRESS;
                                    Database=S12;
                                    Integrated Security=true;
                                    TrustServerCertificate=true;";
        DataSet ds = new DataSet();

        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();

        BindingSource parentBS = new BindingSource();
        BindingSource childBS = new BindingSource();

        public SucuriNaturaleMasterDetailForm()
        {
            InitializeComponent();

            parentDataGridView.MultiSelect = false;
            childDataGridView.MultiSelect = false;

            parentDataGridView.EnableHeadersVisualStyles = false;
            //parentDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(parentDataGridView.Font, FontStyle.Bold);

            childDataGridView.EnableHeadersVisualStyles = false;
            //childDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(childDataGridView.Font, FontStyle.Bold);

            parentDataGridView.RowsDefaultCellStyle.BackColor = Color.DarkOrange;
            parentDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.PeachPuff;

            childDataGridView.RowsDefaultCellStyle.BackColor = Color.PeachPuff;
            childDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;

            this.Text = "Magazin virtual de sucuri naturale";
            this.Icon = new Icon("../../appIcon.ico");
            this.BackgroundImage = Image.FromFile("../../backgroundImage.png");
        }

        private void SucuriNaturaleMasterDetailWindow_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM [S12].[dbo].[TipuriSucuriNaturale];", conn);
                    childAdapter.SelectCommand = new SqlCommand("SELECT * FROM [S12].[dbo].[SucuriNaturale];", conn);

                    parentAdapter.Fill(ds, "TipuriSucuriNaturale");
                    childAdapter.Fill(ds, "SucuriNaturale");

                    DataColumn parentColumn = ds.Tables["TipuriSucuriNaturale"].Columns["TSid"];
                    DataColumn childColumn = ds.Tables["SucuriNaturale"].Columns["TSid"];

                    DataRelation relation = new DataRelation("fk_sucuri_naturale", parentColumn, childColumn);
                    ds.Relations.Add(relation);

                    parentBS.DataSource = ds.Tables["TipuriSucuriNaturale"];
                    parentDataGridView.DataSource = parentBS;
                    childBS.DataSource = parentBS;
                    childBS.DataMember = "fk_sucuri_naturale";
                    childDataGridView.DataSource = childBS;

                    TSidComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                    SqlCommand selectTSidCommand = new SqlCommand("SELECT [TSid] FROM [S12].[dbo].[TipuriSucuriNaturale];", conn);
                    SqlDataReader reader = selectTSidCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            TSidComboBox.Items.Add(reader.GetInt32(0));
                        }
                    }
                    reader.Close();

                    TSidComboBox.SelectedIndex = 0;

                    childDataGridView.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adaugareBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand insertCommand = new SqlCommand("INSERT INTO [S12].[dbo].[SucuriNaturale] " +
                        "([Denumire], [Producator], [Gramaj], [Pret], [DataExpirare], [TSid]) " +
                        "VALUES (@denumire, @producator, @gramaj, @pret, @data_expirare, @tsid);", conn);
                    insertCommand.Parameters.AddWithValue("@denumire", denumireInput.Text);
                    insertCommand.Parameters.AddWithValue("@producator", producatorInput.Text);
                    insertCommand.Parameters.AddWithValue("@gramaj", gramajNumericUpDown.Value);
                    insertCommand.Parameters.AddWithValue("@pret", pretNumericUpDown.Value);
                    insertCommand.Parameters.AddWithValue("@data_expirare", dataExpirareDatePicker.Value);
                    insertCommand.Parameters.AddWithValue("@tsid", TSidComboBox.Text);

                    int insertRowCount = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Insert Row Count: {0}", insertRowCount);

                    if (insertRowCount != 0)
                    {
                        MessageBox.Show("[+]Adaugare realizata cu succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshBtn.Focus();
                    }
                    else
                    {
                        MessageBox.Show("[!]Adaugarea nu s-a putut realiza!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificareBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand updateCommand = new SqlCommand("UPDATE [S12].[dbo].[SucuriNaturale] SET [Denumire]=@denumire, [Producator]=@producator, [Gramaj]=@gramaj, [Pret]=@pret, [DataExpirare]=@data_expirare, [TSid]=@tsid WHERE " +
                        "[Sid]=@sid;", conn);
                    updateCommand.Parameters.AddWithValue("@denumire", denumireInput.Text);
                    updateCommand.Parameters.AddWithValue("@producator", producatorInput.Text);
                    updateCommand.Parameters.AddWithValue("@gramaj", gramajNumericUpDown.Value);
                    updateCommand.Parameters.AddWithValue("@pret", pretNumericUpDown.Value);
                    updateCommand.Parameters.AddWithValue("@data_expirare", dataExpirareDatePicker.Value);
                    updateCommand.Parameters.AddWithValue("@tsid", TSidComboBox.Text);
                    updateCommand.Parameters.AddWithValue("@sid", sidNumericUpDown.Value);

                    int updateRowCount = updateCommand.ExecuteNonQuery();
                    Console.WriteLine("Update Row Count: {0}", updateRowCount);

                    if (updateRowCount != 0)
                    {
                        MessageBox.Show("[&]Modificare realizata cu succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshBtn.Focus();
                    }
                    else
                    {
                        MessageBox.Show("[!]Modificarea nu s-a putut realiza (nu exista un suc natural cu id-ul introdus)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stergereBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti sucul natural cu id-ul #" + sidNumericUpDown.Value + "?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand deleteCommand = new SqlCommand("DELETE FROM [S12].[dbo].[SucuriNaturale] WHERE [Sid]=@sid;", conn);
                        deleteCommand.Parameters.AddWithValue("@sid", sidNumericUpDown.Value);

                        int deleteRowCount = deleteCommand.ExecuteNonQuery();
                        Console.WriteLine("Delete Row Count: {0}", deleteRowCount);

                        if (deleteRowCount != 0)
                        {
                            MessageBox.Show("[-]Stergere realizata cu succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshBtn.Focus();
                        }
                        else
                        {
                            MessageBox.Show("[!]Stergerea nu s-a putut realiza (nu exista un suc natural cu id-ul introdus)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearControls()
        {
            sidNumericUpDown.Value = 0;
            denumireInput.Text = "";
            producatorInput.Text = "";
            gramajNumericUpDown.Value = 0;
            pretNumericUpDown.Value = 0;
            dataExpirareDatePicker.Value = DateTime.Now;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            clearControls();
            TSidComboBox.SelectedIndex = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                ds = new DataSet();

                parentAdapter = new SqlDataAdapter();
                childAdapter = new SqlDataAdapter();

                parentBS = new BindingSource();
                childBS = new BindingSource();

                parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM [S12].[dbo].[TipuriSucuriNaturale];", conn);
                childAdapter.SelectCommand = new SqlCommand("SELECT * FROM [S12].[dbo].[SucuriNaturale];", conn);

                parentAdapter.Fill(ds, "TipuriSucuriNaturale");
                childAdapter.Fill(ds, "SucuriNaturale");

                DataColumn parentColumn = ds.Tables["TipuriSucuriNaturale"].Columns["TSid"];
                DataColumn childColumn = ds.Tables["SucuriNaturale"].Columns["TSid"];

                DataRelation relation = new DataRelation("fk_sucuri_naturale", parentColumn, childColumn);
                ds.Relations.Add(relation);

                parentBS.DataSource = ds.Tables["TipuriSucuriNaturale"];
                parentDataGridView.DataSource = parentBS;
                childBS.DataSource = parentBS;
                childBS.DataMember = "fk_sucuri_naturale";
                childDataGridView.DataSource = childBS;

                childDataGridView.ClearSelection();
            }
        }

        private void parentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                childDataGridView.ClearSelection();

                clearControls();

                int index = TSidComboBox.FindString(parentDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                TSidComboBox.SelectedIndex = index;
            }
        }

        private void childDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int sucId;
                int.TryParse(childDataGridView.SelectedRows[0].Cells[0].Value.ToString(), out sucId);
                sidNumericUpDown.Value = sucId;
                
                denumireInput.Text = childDataGridView.SelectedRows[0].Cells[1].Value.ToString();

                producatorInput.Text = childDataGridView.SelectedRows[0].Cells[2].Value.ToString();

                int gramaj;
                int.TryParse(childDataGridView.SelectedRows[0].Cells[3].Value.ToString(), out gramaj);
                gramajNumericUpDown.Value = gramaj;

                int pret;
                int.TryParse(childDataGridView.SelectedRows[0].Cells[4].Value.ToString(), out pret);
                pretNumericUpDown.Value = pret;

                DateTime dataExpirare;
                DateTime.TryParse(childDataGridView.SelectedRows[0].Cells[5].Value.ToString(), out dataExpirare);
                dataExpirareDatePicker.Value = dataExpirare;
            }
        }

        private void MasterDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a confirmation prompt to the user
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa inchideti aplicatia?", "Exit Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                e.Cancel = true; // Cancel the form closing event
            }
        }
    }
}