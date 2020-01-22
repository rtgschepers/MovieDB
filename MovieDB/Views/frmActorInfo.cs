using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDB
{
    public partial class frmActorInfo : Form
    {
        private Actor actor;
        private ActorController ac;

        public frmActorInfo()
        {
            InitializeComponent();

            this.actor = new Actor();
            actor.birthday = DateTime.Now;

            ac = new ActorController();
        }

        public frmActorInfo(Actor actor) : this()
        {
            this.actor = actor;
        }

        private void frmActorInfo_Load(object sender, EventArgs e)
        {
            txbFirstName.DataBindings.Add("Text", actor, "first_name");
            txbLastName.DataBindings.Add("Text", actor, "last_name");
            dtpBirthday.DataBindings.Add("Value", actor, "birthday", true); // Let op de true
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ac.saveActor(actor);
            this.Close();
        }
    }
}
