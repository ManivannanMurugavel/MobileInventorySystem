using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing;

namespace Mobiles
{
	class SwathiClass
	{
		public Image convertImage(Image imgPhoto, Size size)
		{
			//float nPercent = ((float)Percent / 100);

			int sourceWidth = imgPhoto.Width;      //store original width of source image.
			int sourceHeight = imgPhoto.Height;    //store original height of source image.
			int sourceX = 0;        //x-axis of source image.
			int sourceY = 0;         //y-axis of source image.

			int destX = 0;          //x-axis of destination image.
			int destY = 0;          //y-axis of destination image.
									//Calcuate height and width of resized image.
			int destWidth = size.Width;
			int destHeight = size.Height;

			//Create a new bitmap object.
			Bitmap bmPhoto = new Bitmap(destWidth, destHeight,
									 PixelFormat.Format24bppRgb);
			//Set resolution of bitmap.
			bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
									imgPhoto.VerticalResolution);
			//Create a graphics object and set quality of graphics.
			Graphics grPhoto = Graphics.FromImage(bmPhoto);
			grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

			//Draw image by using DrawImage() method of graphics class.
			grPhoto.DrawImage(imgPhoto,
				new Rectangle(destX, destY, destWidth, destHeight),
				new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
				GraphicsUnit.Pixel);

			grPhoto.Dispose();   //Dispose graphics object.
			return bmPhoto;
		}
	}
}
