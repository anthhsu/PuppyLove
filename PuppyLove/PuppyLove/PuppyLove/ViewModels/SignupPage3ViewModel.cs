using System;
using System.Collections.Generic;
using System.Text;

namespace PuppyLove.ViewModels
{
    class SignupPage3ViewModel
    {
        public List<string> StatusList { get; set; } = new List<string>();
        
        public SignupPage3ViewModel()
        {
            StatusList.Add("Man seeking a Woman");
            StatusList.Add("Woman seeking a Man");
            StatusList.Add("A Companion");
        }
        
    }
}
