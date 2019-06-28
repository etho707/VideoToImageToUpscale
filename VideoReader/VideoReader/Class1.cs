using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoReader
{
    public class VideoReader
    {
        public void Pipis()
        {
            using (var engine = new Engine())
            {
                var mp4 = new MediaFile { Filename = @"A:\Tors\Serial_Experiments_Lain_BDRip_480p_Hi10p_[AnimeCeh]\Serial_Experiments_Lain_01_BDRip_480p_Hi10p_[AnimeCeh].mkv" };

                engine.GetMetadata(mp4);

                for (int x=0; x < Convert.ToInt32(mp4.Metadata.Duration.TotalSeconds); x++) { 
                    var options = new ConversionOptions { Seek = TimeSpan.FromSeconds(x) };
                    var outputFile = new MediaFile { Filename = string.Format("{0}\\image-{1}.jpeg", @"A:\Tors\Serial_Experiments_Lain_BDRip_480p_Hi10p_[AnimeCeh]\baka", x) };
                    engine.GetThumbnail(mp4, outputFile, options);
                };
                
            }
        }
    }
}
