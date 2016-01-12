using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStore
{
    public class UtilityClass
    {
        public static bool ShowErrorMsg(dynamic obj, string msg)
        {
            if (obj == null)
            {
                MessageBox.Show(msg);
                return true;
            }

            return false;
        }

        public static bool IsInMovieCatalog(dynamic movieCatalog, string currentTitle)
        {
            foreach (var item in movieCatalog)
            {
                if (item.Title.Equals(currentTitle))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
