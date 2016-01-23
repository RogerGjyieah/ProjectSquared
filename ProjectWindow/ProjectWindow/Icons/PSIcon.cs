using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWindow.Icons
{
    public class PSIcon
    {
        #region string constants
        public static readonly string MEMBER = "member";
        public static readonly string PROJECT = "project";
        #endregion

        private static PSIcon instance;

        private string[] iconNames; 

        private Dictionary<string, Image> loadedIcons;

        private PSIcon()
        {
            LoadIconNames();
            IsLoaded = false;
            loadedIcons = new Dictionary<string, Image>();
        }

        private void LoadIconNames()
        {
            iconNames = new string[] {
                MEMBER, 
                PROJECT
            };
        }

        public static PSIcon GetInstance()
        {
            if (instance == null)
            {
                instance = new PSIcon();
            }
            return instance;
        }

        public bool IsLoaded { get; private set; }


        public void Load()
        {
            foreach (string iconName in iconNames)
            {
                loadedIcons.Add(iconName, ProcessIcon(iconName));
            }

            IsLoaded = true;
        }

        private Image ProcessIcon(string file)
        {

            object icon = Resource.ResourceManager.GetObject(file, Resource.Culture);

            Bitmap bmp = (Bitmap)icon;

            bmp.MakeTransparent(bmp.GetPixel(0, 0));

            /*
            int height = bmp.Height;
            int width = bmp.Width;

            Image[] iconParts = new Image[8];
            Bitmap[] parts = new Bitmap[8];

            for (int i = 0; i < 8; i++)
            {
                parts[i] = new Bitmap(bmp);
            }

            Parallel.For(0, 8, (i) =>
            {
                Bitmap part = parts[i];

                for (int x = 0; x < width / 8; x++)
                {
                    for (int y = 0; y < height; y++)
                    {

                        if (part.GetPixel(x * i + 1, y).Equals(part.GetPixel(0, 0)))
                        {
                            part.SetPixel(x * i + 1, y, Color.FromArgb(0, 0, 0, 0));
                        }
                    }
                }
                iconParts[i] = part;
            });

            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.FromArgb(0, 0, 0, 0));
            foreach (Image iconPart in iconParts)
            {
                g.DrawImage(iconPart, 0, 0);
            }

            bmp.SetPixel(0, 0, Color.FromArgb(0, 0, 0, 0));
            */
            return bmp;
        }

        public Image GetIcon(string name)
        {
            if (IsLoaded)
            {
                return loadedIcons[name];
            }
            else
            {
                throw new Exception("Icons not loaded");
            }
        }
    }
}
