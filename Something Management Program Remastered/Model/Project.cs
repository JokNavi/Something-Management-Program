﻿using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text.Json.Serialization;

namespace Something_Management_Program_Remastered.Model
{
    public partial class Project : ObservableObject, INotifyPropertyChanged
    {

        [ObservableProperty]
        private ObservableCollection<ObjectiveValue> objectiveValueCollection;

        [ObservableProperty]
        private ObservableCollection<Modifier> modifierTree = new();

        [ObservableProperty]
        private ObservableCollection<Modifier> displayModifiers;

        [JsonConstructor]
        public Project()
        {
            DisplayModifiers = ModifierTree.LastOrDefault(new Modifier()).Modifiers;
        }
    }
}
