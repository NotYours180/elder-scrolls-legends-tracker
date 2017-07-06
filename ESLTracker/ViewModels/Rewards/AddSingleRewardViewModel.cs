﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ESLTracker.Controls.Rewards;
using ESLTracker.DataModel;
using ESLTracker.DataModel.Enums;
using ESLTracker.Services;
using ESLTracker.Utils;

namespace ESLTracker.ViewModels.Rewards
{
    public class AddSingleRewardViewModel : ViewModelBase
    {
        private Reward reward;
        public Reward Reward
        {
            get { return reward; }
            set {
                SetProperty(ref reward, value);
                
                InitTypeSpecifics(this.reward.Type);
            }
        }

        private bool cardSelectionVisible;
        public bool CardSelectionVisible
        {
            get { return cardSelectionVisible && reward.Type == RewardType.Card; }
            set { SetProperty(ref cardSelectionVisible, value); }
        }

        public IEnumerable<string> CardNamesList
        {
            get
            {
                return cardsDatabase.CardsNames;
            }
        }

        public string BackgroundImagePath
        {
            get
            {
                return @"pack://application:,,,/"
                 + "Resources/RewardType/" + reward.Type.ToString() + ".png";
            }
        }

        public RewardSetViewModel ParentRewardViewModel { get; set; }

        //command for add button
        public ICommand CommandAddButtonPressed
        {
            get { return new RelayCommand(new Action<object>(AddClicked)); }
        }

        //command command for close icon
        public ICommand CommandDeleteClicked
        {
            get { return new RelayCommand(new Action<object>(DeleteClicked)); }
        }

        private ITrackerFactory trackerFactory;
        ICardsDatabase cardsDatabase;

        public AddSingleRewardViewModel() : this(TrackerFactory.DefaultTrackerFactory)
        {

        }

        public AddSingleRewardViewModel(ITrackerFactory trackerFactory)
        {
            this.trackerFactory = trackerFactory;
            cardsDatabase = trackerFactory.GetService<ICardsDatabase>();
        }

        private void InitTypeSpecifics(RewardType value)
        {
            switch (reward.Type)
            {
                case RewardType.Gold:
                    CardSelectionVisible = false;
                    break;
                case RewardType.SoulGem:
                    CardSelectionVisible = false;
                    break;
                case RewardType.Pack:
                    CardSelectionVisible = false;
                    break;
                case RewardType.Card:
                    if (Reward.CardInstance == null)
                    {
                        Reward.CardInstance = new CardInstance(this.trackerFactory);
                        Reward.CardInstance.PropertyChanged += Reward_PropertyChanged;
                    }
                    CardSelectionVisible = true;
                    break;
                default:
                    break;
            }
            RaisePropertyChangedEvent("Reward");
        }

        public void AddClicked(object param)
        {
            ParentRewardViewModel.AddNewReward((RewardType)param);
        }

        public void DeleteClicked(object param)
        {
            ParentRewardViewModel.DeleteReward(param as Reward);
        }

        private void Reward_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(e.PropertyName) || (e.PropertyName == nameof(reward.CardInstance)))
            {
                if (Reward.Quantity == 0) //do not update when already modified 
                {
                    Reward.Quantity = 1;
                }
                RaisePropertyChangedEvent(nameof(Reward)); //udate ui
            }
        }
    }
}
