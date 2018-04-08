using PuppyLove.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PuppyLove.ViewModels
{
    class MatchPageViewModel
    {

        public ObservableCollection<Person> People { get; set; }

        public MatchPageViewModel()
        {
            People = new ObservableCollection<Person>
            {
                new Person
                {
                    Name = "Michelle Hsu",
                    PetName = "Frumpy",
                    ImageURL = "https://d1u5p3l4wpay3k.cloudfront.net/zelda_gamepedia_en/thumb/a/a0/Fairy_The_Wind_Waker_HD.png/300px-Fairy_The_Wind_Waker_HD.png?version=1fe80cef9577b05cc220621a66182996.png"
                },
                new Person
                {
                    Name = "Chris Hsu",
                    PetName = "Nugget",
                    ImageURL = "http://moziru.com/images/wilderness-clipart-movie-16.png"
                }
            };            
        }       

    }
}
