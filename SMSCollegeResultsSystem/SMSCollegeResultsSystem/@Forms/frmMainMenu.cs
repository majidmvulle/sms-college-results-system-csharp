using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMSCollegeResultsSystem._Forms
{
    public partial class frmMainMenu : Form
    {
        private int childFormNumber = 0;

        frmAbout about;
        frmResultsCalc resultsCalc;
        frmAddResults addResults;
        frmViewResults viewResults;
        frmDeleteResults deleteResults;
        frmAddSchool addSchool;
        frmViewSchool viewSchool;
        frmDeleteSchool deleteSchool;
        frmAddDept addDept;
        frmViewDept viewDept;
        frmDeleteDept deleteDept;
        frmAddModule addModule;
        frmViewModule viewModule;
        frmDeleteModule deleteModule;
        frmAddLecturer addLecturer;
        frmViewLecturer viewLecturer;
        frmDeleteLecturer deleteLecturer;
        frmAddStudent addStudent;
        frmViewStudent viewStudent;
        frmDeleteStudent deleteStudent;
        frmRegStudMod regStudMod;
        frmDeRegStudMod deRegStudMod;
        frmViewAllResults viewAllResults;
        frmAddModulesOfferedNext addModuleOffered;
        frmRemoveModule removeModule;
        frmRemoveAllModulesOffered removeAllModules;

        frmViewAllModules viewAllModules;
        frmViewAllLect viewAllLect;
        frmViewAllPrereg viewAllPrereg;
        frmViewAllStudents viewAllStuds;
        frmViewAllStudModReg viewAllStudModReg;

       

        private void ShowNewForm(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new Form();
            // Make it a child of this MDI form before showing it.
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        public frmMainMenu()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Display a message box asking users if they
            // want to exit the application.
            if (MessageBox.Show("Do you want to exit?", "SMS College Results System",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                  == DialogResult.OK)
            {
                Application.Exit();
            }


        }

        private void btnRefreshUtil_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            //Garbage collection.
            //Dispose object "about" before creating another one

            if (about != null)
                about.Dispose();

            about = new frmAbout();

            about.Disposed += delegate
            {
                about.Dispose();
                about = null;
            };

            about.Show();
        }

        private void btnResultsCalc_Click(object sender, EventArgs e)
        {

            //Garbage collection.
            //Dispose object "resultsCalc" before creating another one

            if (resultsCalc != null)
                resultsCalc.Dispose();

            resultsCalc = new frmResultsCalc();

            resultsCalc.Disposed += delegate
            {
                resultsCalc.Dispose();
                resultsCalc = null;
            };

            resultsCalc.Show();

        }

        private void btnAddResults_Click(object sender, EventArgs e)
        {
            if (addResults != null)
                addResults.Dispose();

            addResults = new frmAddResults();

            addResults.Disposed += delegate
            {
                addResults.Dispose();
                addResults = null;
            };

            addResults.Show();
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            if (viewResults != null)
                viewResults.Dispose();

            viewResults = new frmViewResults();

            viewResults.Disposed += delegate
            {
                viewResults.Dispose();
                viewResults = null;
            };

            viewResults.Show();
        }

        private void btnDeleteResults_Click(object sender, EventArgs e)
        {
            if (deleteResults != null)
                deleteResults.Dispose();

            deleteResults = new frmDeleteResults();

            deleteResults.Disposed += delegate
            {
                deleteResults.Dispose();
                deleteResults = null;
            };

            deleteResults.Show();
        }

        private void btnAddSchool_Click(object sender, EventArgs e)
        {
            if (addSchool != null)
                addSchool.Dispose();

            addSchool = new frmAddSchool();

            addSchool.Disposed += delegate
            {
                addSchool.Dispose();
                addSchool = null;
            };

            addSchool.Show();
        }

        private void btnViewSchool_Click(object sender, EventArgs e)
        {
            if (viewSchool != null)
                viewSchool.Dispose();

            viewSchool = new frmViewSchool();

            viewSchool.Disposed += delegate
            {
                viewSchool.Dispose();
                viewSchool = null;
            };

            viewSchool.Show();
        }
        
        private void btnDeleteSchool_Click(object sender, EventArgs e)
        {
            if (deleteSchool != null)
                deleteSchool.Dispose();

            deleteSchool = new frmDeleteSchool();

            deleteSchool.Disposed += delegate
            {
                deleteSchool.Dispose();
                deleteSchool = null;
            };

            deleteSchool.Show();
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            if (addDept != null)
                addDept.Dispose();

            addDept = new frmAddDept();

            addDept.Disposed += delegate
            {
                addDept.Dispose();
                addDept = null;
            };

            addDept.Show();
        }

        private void btnViewDept_Click(object sender, EventArgs e)
        {
            if (viewDept != null)
                viewDept.Dispose();

            viewDept = new frmViewDept();

            viewDept.Disposed += delegate
            {
                viewDept.Dispose();
                viewDept = null;
            };

            viewDept.Show();
        }

        private void btnDeleteDept_Click(object sender, EventArgs e)
        {
            if (deleteDept != null)
                deleteDept.Dispose();

            deleteDept = new frmDeleteDept();

            deleteDept.Disposed += delegate
            {
                deleteDept.Dispose();
                deleteDept = null;
            };

            deleteDept.Show();
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            if (addModule != null)
                addModule.Dispose();

            addModule = new frmAddModule();

            addModule.Disposed += delegate
            {
                addModule.Dispose();
                addModule = null;
            };

            addModule.Show();

        }

        private void btnViewModule_Click(object sender, EventArgs e)
        {
            if (viewModule != null)
                viewModule.Dispose();

            viewModule = new frmViewModule();

            viewModule.Disposed += delegate
            {
                viewModule.Dispose();
                viewModule = null;
            };

            viewModule.Show();

        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            if (deleteModule != null)
                deleteModule.Dispose();

            deleteModule = new frmDeleteModule();

            deleteModule.Disposed += delegate
            {
                deleteModule.Dispose();
                deleteModule = null;
            };

            deleteModule.Show();

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (addLecturer != null)
                addLecturer.Dispose();

            addLecturer = new frmAddLecturer();

            addLecturer.Disposed += delegate
            {
                addLecturer.Dispose();
                addLecturer = null;
            };

            addLecturer.Show();

        }

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            if (viewLecturer != null)
                viewLecturer.Dispose();

            viewLecturer = new frmViewLecturer();

            viewLecturer.Disposed += delegate
            {
                viewLecturer.Dispose();
                viewLecturer = null;
            };

            viewLecturer.Show();

        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (deleteLecturer != null)
                deleteLecturer.Dispose();

            deleteLecturer = new frmDeleteLecturer();

            deleteLecturer.Disposed += delegate
            {
                deleteLecturer.Dispose();
                deleteLecturer = null;
            };

            deleteLecturer.Show();

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (addStudent != null)
                addStudent.Dispose();

            addStudent = new frmAddStudent();

            addStudent.Disposed += delegate
            {
                addStudent.Dispose();
                addStudent = null;
            };

            addStudent.Show();

        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            if (viewStudent != null)
                viewStudent.Dispose();

            viewStudent = new frmViewStudent();

            viewStudent.Disposed += delegate
            {
                viewStudent.Dispose();
                viewStudent = null;
            };

            viewStudent.Show();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (deleteStudent != null)
                deleteStudent.Dispose();

            deleteStudent = new frmDeleteStudent();

            deleteStudent.Disposed += delegate
            {
                deleteStudent.Dispose();
                deleteStudent = null;
            };

            deleteStudent.Show();
        }

        

        private void btnRegisStudMod_Click(object sender, EventArgs e)
        {
            if (regStudMod != null)
                regStudMod.Dispose();

            regStudMod = new frmRegStudMod();

            regStudMod.Disposed += delegate
            {
                regStudMod.Dispose();
                regStudMod = null;
            };

            regStudMod.Show();
        }

        private void btnDeRegStudMod_Click(object sender, EventArgs e)
        {
            if (deRegStudMod != null)
                deRegStudMod.Dispose();

            deRegStudMod = new frmDeRegStudMod();

            deRegStudMod.Disposed += delegate
            {
                deRegStudMod.Dispose();
                deRegStudMod = null;
            };

            deRegStudMod.Show();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            if (viewAllResults != null)
                viewAllResults.Dispose();

            viewAllResults = new frmViewAllResults();

            viewAllResults.Disposed += delegate
            {
                viewAllResults.Dispose();
                viewAllResults = null;
            };

            viewAllResults.Show();

        }
      
        private void btnAddModOffered_Click(object sender, EventArgs e)
        {
            if (addModuleOffered != null)
                addModuleOffered.Dispose();

            addModuleOffered = new frmAddModulesOfferedNext();

            addModuleOffered.Disposed += delegate
            {
                addModuleOffered.Dispose();
                addModuleOffered = null;
            };

            addModuleOffered.Show();
        }

        private void btnRemoveModOffered_Click(object sender, EventArgs e)
        {
            if (removeModule != null)
                removeModule.Dispose();

            removeModule = new frmRemoveModule();

            removeModule.Disposed += delegate
            {
                removeModule.Dispose();
                removeModule = null;
            };

            removeModule.Show();
        }

        private void btnRemoveAllModules_Click(object sender, EventArgs e)
        {
            if (removeAllModules != null)
                removeAllModules.Dispose();

            removeAllModules = new frmRemoveAllModulesOffered();

            removeAllModules.Disposed += delegate
            {
                removeAllModules.Dispose();
                removeAllModules = null;
            };

            removeAllModules.Show();
        }

        private void btnViewAllLect_Click(object sender, EventArgs e)
        {
            if (viewAllLect != null)
                viewAllLect.Dispose();

            viewAllLect = new frmViewAllLect();

            viewAllLect.Disposed += delegate
            {
                viewAllLect.Dispose();
                viewAllLect = null;
            };

            viewAllLect.Show();
        }

        private void btnViewAllStud_Click(object sender, EventArgs e)
        {
            if (viewAllStuds != null)
                viewAllStuds.Dispose();

            viewAllStuds = new frmViewAllStudents();

            viewAllStuds.Disposed += delegate
            {
                viewAllStuds.Dispose();
                viewAllStuds = null;
            };

            viewAllStuds.Show();
        }

        private void btnViewAllMods_Click(object sender, EventArgs e)
        {
            if (viewAllModules != null)
                viewAllModules.Dispose();

            viewAllModules = new frmViewAllModules();

            viewAllModules.Disposed += delegate
            {
                viewAllModules.Dispose();
                viewAllModules = null;
            };

            viewAllModules.Show();
        }


        private void btnViewAllStudModReg_Click(object sender, EventArgs e)
        {
            if (viewAllStudModReg != null)
                viewAllStudModReg.Dispose();

            viewAllStudModReg = new frmViewAllStudModReg();

            viewAllStudModReg.Disposed += delegate
            {
                viewAllStudModReg.Dispose();
                viewAllStudModReg = null;
            };

            viewAllStudModReg.Show();
        }

        private void btnViewAllPrereg_Click(object sender, EventArgs e)
        {
            if (viewAllPrereg != null)
                viewAllPrereg.Dispose();

            viewAllPrereg = new frmViewAllPrereg();

            viewAllPrereg.Disposed += delegate
            {
                viewAllPrereg.Dispose();
                viewAllPrereg = null;
            };

            viewAllPrereg.Show();
        }


    }
}
