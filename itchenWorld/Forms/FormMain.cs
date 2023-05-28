using itchenWorld.Forms;
using itchenWorld.Forms.FormsDeportement;
using itchenWorld.Forms.FormsEquipment;
using itchenWorld.Forms.FormsMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itchenWorld
{
    public partial class FormMain : Form
    {
        int AccessLevel;
        public FormMain( int accessLevel)
        {
            AccessLevel = accessLevel;
            InitializeComponent();
            if(AccessLevel == 1)
            {
                EuqipmentToolStripMenuItem.Enabled = false;
                DepartementToolStripMenuItem.Enabled = false;
            }
            if(AccessLevel == 2)
            {
                DepartementToolStripMenuItem.Enabled = false;
            }
        }

        private void KitchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitchen kitchen = new Kitchen(AccessLevel);
            kitchen.MdiParent = this;
            kitchen.Show();
        }

        private void DishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dish dish = new Dish(AccessLevel);
            dish.MdiParent = this;
            dish.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product product = new Product(AccessLevel);
            product.MdiParent = this;
            product.Show();
        }

        private void InventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory(AccessLevel);
            inventory.MdiParent = this;
            inventory.Show();
        }

        private void ProviderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider(AccessLevel);
            provider.MdiParent = this;
            provider.Show();
        }

        private void ContactPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContectPerson contectPerson = new ContectPerson(AccessLevel);
            contectPerson.MdiParent = this;
            contectPerson.Show();
        }

        private void empolyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(AccessLevel);
            employee.MdiParent = this;
            employee.Show();
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilatesLight light = new utilatesLight(AccessLevel);
            light.MdiParent = this;
            light.Show();
        }

        private void workingDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeWorked employeeWorked = new EmployeeWorked(AccessLevel);
            employeeWorked.MdiParent = this;
            employeeWorked.Show();
        }

        private void personalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeePersonalData employeePersonal = new EmployeePersonalData(AccessLevel);
            employeePersonal.MdiParent = this;
            employeePersonal.Show();
        }

        private void departamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departament departament = new Departament(AccessLevel);
            departament.MdiParent = this;
            departament.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock(AccessLevel);
            stock.MdiParent = this;
            stock.Show();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room room = new Room(AccessLevel);
            room.MdiParent = this;
            room.Show();
        }

        private void purcaheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase(AccessLevel);
            purchase.MdiParent = this;
            purchase.Show();
        }

        private void purcacheDescriotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositePurcahe compositePurcahe = new CompositePurcahe(AccessLevel);
            compositePurcahe.MdiParent = this;
            compositePurcahe.Show();
        }

        private void SelectDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSempling dataSempling = new DataSempling();
            dataSempling.MdiParent = this;
            dataSempling.Show();
        }
    }
}
