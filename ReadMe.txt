C# ReturnStructure Library

To return structured data from function

*******************************************************************************

Example of use

ReturnStructure TestFunction(Exception ex)
{
    ReturnStructure rs = new ReturnStructure();
    rs.StatusCode = 0;
    rs.Message = "Status Code OK";
    rs.Exception = ex;
    return (rs);
}

ReturnStructure TestFunction2(Exception ex)
{
    return (new ReturnStructure(0, "Status Code OK", ex);
}

ReturnStructure TestFunction3()
{
    Exception ex = new Exception();
    return (new ReturnStructure(0, "Status Code OK", ex);
}

please give me some star if you will see that the library is useful, thank you
