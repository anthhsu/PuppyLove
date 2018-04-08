using System;
using System.Collections.Generic;
using System.Text;

namespace PuppyLove.ViewModels
{
    class SignupPage4ViewModel
    {
        public List<string> BreedList = new List<string>();

        public SignupPage4ViewModel()
        {
            BreedList.Add("Black Lab");
            BreedList.Add("Golden Retriever");
            BreedList.Add("Husky");
            BreedList.Add("Poodle");
        }
    }
}
