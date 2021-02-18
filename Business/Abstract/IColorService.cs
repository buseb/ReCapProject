using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAllColors();
        IDataResult<Color> GetColorById(int id);
        IResult Add(Color color);
    }
}
