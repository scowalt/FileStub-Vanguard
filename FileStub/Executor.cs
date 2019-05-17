﻿using RTCV.CorruptCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileStub
{
    static class Executor
    {
        public static string otherProgram = null;
        public static string script = null;

        public static void EditExec()
        {
            var gh = WFV_Core.ghForm;

            if (gh.rbExecuteOtherProgram.Checked || gh.rbExecuteWith.Checked)
            {
                OpenFileDialog OpenFileDialog1;
                OpenFileDialog1 = new OpenFileDialog();

                OpenFileDialog1.Title = "Open File";
                OpenFileDialog1.Filter = "files|*.*";
                OpenFileDialog1.RestoreDirectory = true;
                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (OpenFileDialog1.FileName.ToString().Contains('^'))
                    {
                        MessageBox.Show("You can't use a file that contains the character ^ ");
                        return;
                    }

                    otherProgram = OpenFileDialog1.FileName.ToString();
                }
                else
                    return;
            }
            else if (gh.rbExecuteScript.Checked)
            {
                MessageBox.Show("UNIMPLEMENTED");
            }

            RefreshLabel();

        }

        public static void Execute()
        {
            var gh = WFV_Core.ghForm;

            //Hijack no execution for the Netcore executor
            if (gh.rbNoExecution.Checked)
            {

            }
            else if (gh.rbExecuteCorruptedFile.Checked)
            {
                if (WFV_Core.currentTargetType == "File")
                {
                    var fi = (FileInterface)WFV_Core.currentMemoryInterface;
                    //Process.Start(fi.filename);

                    string fullPath = fi.Filename;
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = Path.GetFileName(fullPath);
                    psi.WorkingDirectory = Path.GetDirectoryName(fullPath);
                    //psi.Arguments = "p1=hardCodedv1 p2=" + MakeParameter();
                    Process.Start(psi);
                }
                else
                    return;
                    
            }
            else if (gh.rbExecuteWith.Checked)
            {
                if (otherProgram != null)
                {
                    var fi = (FileInterface)WFV_Core.currentMemoryInterface;
                    //Process.Start(otherProgram, "\"" + fi.filename + "\"");

                    string fullPath = otherProgram;
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = Path.GetFileName(fullPath);
                    psi.WorkingDirectory = Path.GetDirectoryName(fullPath);
                    psi.Arguments = "\"" + fi.Filename + "\"";
                    Process.Start(psi);

                }
                else
                    return;
            }
            else if (gh.rbExecuteOtherProgram.Checked)
            {
                if (otherProgram != null)
                {

                    string fullPath = otherProgram;
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = Path.GetFileName(fullPath);
                    psi.WorkingDirectory = Path.GetDirectoryName(fullPath);

                    if (!string.IsNullOrWhiteSpace(WFV_Core.ghForm.tbArgs.Text))
                        psi.Arguments = WFV_Core.ghForm.tbArgs.Text.Trim(); ;

                    Process.Start(psi);

                }
                else
                    return;
            }
            else if (gh.rbExecuteScript.Checked)
            {
                MessageBox.Show("UNIMPLEMENTED");
            }
        }

        public static void RefreshLabel()
        {
            var gh = WFV_Core.ghForm;

            gh.lbArgs.Visible = false;
            gh.tbArgs.Visible = false;

            if (gh.rbNoExecution.Checked)
                gh.lbExecution.Text = "No execution set";
            else if (gh.rbExecuteCorruptedFile.Checked)
                gh.lbExecution.Text = "The target file will be executed after corruption";
            else if (gh.rbExecuteWith.Checked)
            {
                if (otherProgram == null)
                {
                    gh.lbExecution.Text = "No program selected for execution";
                }
                else
                {
                    gh.lbExecution.Text = "Target will be executed using " + otherProgram.Substring(otherProgram.LastIndexOf('\\') + 1);
                }
            }
            else if (gh.rbExecuteOtherProgram.Checked)
            {
                gh.lbArgs.Visible = true;
                gh.tbArgs.Visible = true;

                if (otherProgram == null)
                {
                    gh.lbExecution.Text = "No program selected for execution";
                }
                else
                {
                    gh.lbExecution.Text = otherProgram.Substring(otherProgram.LastIndexOf('\\') + 1) + " will be executed after corruption";
                }
            }
            else if (gh.rbExecuteScript.Checked)
            {
                if (otherProgram == null)
                {
                    gh.lbExecution.Text = "No script loaded";
                }
                else
                {
                    gh.lbExecution.Text = script;
                }
            }


        }

    }


}
