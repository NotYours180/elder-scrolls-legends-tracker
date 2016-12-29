﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;
using ESLTracker.Utils;
using ESLTracker.ViewModels;

namespace ESLTracker.DataModel
{
    [DebuggerDisplay("Card={Card.Name}; Golden={IsGolden}")]
    public class CardInstance : ViewModelBase
    {
        private ITrackerFactory trackerFactory;

        public Guid CardId
        {
            get
            {
                return Card != null ? Card.Id : Card.Unknown.Id;
            }
            set
            {
                LoadCardFromDataBase(value);
            }
        }

        Card card;
        [XmlIgnore]
        public Card Card
        {
            get { return card; }
            set { card = value; }
        }
        private bool isGolden;

        public bool IsGolden
        {
            get { return isGolden; }
            set { isGolden = value;  RaisePropertyChangedEvent(nameof(IsGolden)); }
        }

        public Brush BackgroundColor
        {
            get
            {
                if ((Card != null) && (Card != Card.Unknown))
                {
                    System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(60+265, 55);
                    using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap))
                    {
                        System.Drawing.Bitmap i1 = new System.Drawing.Bitmap(Application.GetResourceStream(new Uri("pack://application:,,,/Resources/DeckAttribute/" + card.Attributes.ToString("a") + "back.png", UriKind.RelativeOrAbsolute)).Stream);
                        System.Drawing.Bitmap i2 = new System.Drawing.Bitmap(Application.GetResourceStream(new Uri(ImageSource, UriKind.RelativeOrAbsolute)).Stream);
                        g.DrawImage(i1, 0, 0);
                        g.DrawImage(i1, 0, 15);
                        g.DrawImage(i1, 0, 30);
                        g.DrawImage(i1, 0, 45);
                        g.DrawImage(i2, i1.Width, 0, 265, 55);
                    }

                    using (MemoryStream memory = new MemoryStream())
                    {
                        bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
                        memory.Position = 0;
                        BitmapImage bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.StreamSource = memory;
                        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                        bitmapImage.EndInit();
                        return new ImageBrush(bitmapImage) { Stretch = Stretch.Fill };

                    }
                }
                else
                {
                    return new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                }
            }
        }

        public Brush ForegroundColor
        {
            get
            {
                if ((Card != null) && (Card != Card.Unknown))
                {
                    return new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                }
                else
                {
                    return new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                }
            }
        }

        public Brush RarityColor
        {
            get
            {
                if ((Card != null) && (Card != Card.Unknown))
                {
                    switch (Card.Rarity)
                    {
                        case Enums.CardRarity.Common:
                            return new SolidColorBrush(Color.FromArgb(255, 199, 199, 199));
                            break;
                        case Enums.CardRarity.Rare:
                            return new SolidColorBrush(Color.FromArgb(255, 98, 192, 239));
                            break;
                        case Enums.CardRarity.Epic:
                            return new SolidColorBrush(Color.FromArgb(255, 193, 86, 203));
                            break;
                        case Enums.CardRarity.Legendary:
                            return new SolidColorBrush(Color.FromArgb(255, 252, 252, 122));
                            break;
                        default:
                            throw new NotImplementedException("Unknown card rarity");
                            break;
                    }                    
                }
                else
                {
                    return new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                }
            }
        }

        public string ImageSource
        {
            get
            {
                Regex rgx = new Regex("[^a-zA-Z0-9]");
                if (Card != null)
                {
                    var name = rgx.Replace(Card?.Name, "");
                    return "pack://application:,,,/Resources/Cards/" + name + ".png";
                }
                else
                {
                    return String.Empty;
                }
            }
        }

        public CardInstance() : this(TrackerFactory.DefaultTrackerFactory)
        {

        }

        public CardInstance(Card card) : this(card, TrackerFactory.DefaultTrackerFactory)
        {

        }

        public CardInstance(ITrackerFactory trackerFactory) : this(null, trackerFactory)
        {
            
        }

        public CardInstance(Card card, ITrackerFactory trackerFactory)
        {
            this.Card = card;
            this.trackerFactory = trackerFactory;
        }

        private void LoadCardFromDataBase(Guid value)
        {
            this.Card = trackerFactory.GetCardsDatabase().FindCardById(value);
        }
    }
}