using AdministratorWydarzen.Presenter;
using System.Windows.Forms;

namespace AdministratorWydarzen
{
    public partial class EventView : Form
    {
        private readonly EventPresenter _presenter;
        public EventView()
        {
            InitializeComponent();
        }
        public event Action Add;
        public event Action<int> Delete;
        public event Action Save;
        public event Action Read;
        public event Action<string> Sort;
        public event Action <string, DateTime>Filter;
        public event Action RowColorChange;
        public event Func<int, string> DetailedDescription;
        public string Title { get => textBoxTitle.Text; set => textBoxTitle.Text = value; }
        public string Description { get => richTextBox1.Text; set => richTextBox1.Text = value; }
        public string Type { get => comboBox1.Text; set => comboBox1.Text = value; }
        public string Priority { get => comboBox2.Text; set => comboBox2.Text = value; }
        public DateTime Date { get => monthCalendar1.SelectionRange.Start; set => monthCalendar1.SelectionRange.Start = value; }


        private bool setEmptyTitle(TextBox tb)
        {
            if (tb.Text == "")
            {
                errorProvider1.SetError(tb, "Puste pole");
                return false;
            }
            else
            {
                errorProvider1.SetError(tb, "");
                return true;
            }

        }
        private bool setEmptyDescription(RichTextBox tb)
        {
            if (tb.Text == "")
            {
                errorProvider2.SetError(tb, "Puste pole");
                return false;
            }
            else
            {
                errorProvider2.SetError(tb, "");
                return true;
            }
        }

        private bool setEmptyType(ComboBox cb)
        {
            if (cb.Text == "")
            {
                errorProvider3.SetError(cb, "Puste pole");
                return false;
            }
            else
            {
                errorProvider3.SetError(cb, "");
                return true;
            }

        }

        public void SetEventListBindingSource(BindingSource eventList)
        {
            dataGridView1.DataSource = eventList;
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (setEmptyTitle(textBoxTitle) & setEmptyDescription(richTextBox1) & setEmptyType(comboBox1) & setEmptyType(comboBox2))
            {
                Add?.Invoke();
                RowColorChange?.Invoke();
               
            }



        }

        private void delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            
           Delete?.Invoke(index);
           RowColorChange?.Invoke();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Save?.Invoke();
        }

        private void read_Click(object sender, EventArgs e)
        {
            Read?.Invoke();
            RowColorChange?.Invoke();
        }

        private void sort_Click(object sender, EventArgs e)
        {
            if (setEmptyType(comboBox3))
            {
                Sort?.Invoke(comboBox3.Text);
                
            }

        }

        private void filtr_Click(object sender, EventArgs e)
        {
            if (setEmptyType(comboBox4))
            {
                Filter?.Invoke(comboBox4.Text,monthCalendar1.SelectionRange.Start);   
            }
        }

        public void loadDescription(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                richTextBox2.Clear();
                int index = dataGridView1.SelectedRows[0].Index;
                string d=DetailedDescription?.Invoke(index);
                if(d!=null)
                {
                    richTextBox2.Text = d;
                    
                }
                
            }
            
        }
       
       

        public void SetRowColor(int index, Color color)
        {
            dataGridView1.Rows[index].DefaultCellStyle.BackColor = color;
        }
       

    }
}
