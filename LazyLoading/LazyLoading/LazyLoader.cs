using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LazyLoading
{
public class LazyLoader
{
    private List<string> _filenames = null;
    public List<string> GetFileNames 
    {
        get
        {
            if (_filenames == null)
                LoadFileNames();

            return _filenames;
        }
    }

    private void LoadFileNames()
    {
        // Iterate over a folder and obtain some file names
        // time-consuming!
    }
}
}
