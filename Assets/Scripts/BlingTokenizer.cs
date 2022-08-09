using System.IO;
using BlingFire;
using UnityEngine;

public class BlingTokenizer
{
    public string _tokenizerBinPath, _tokenizerI2WPath;
    public ulong _tokenizerBINHandle, _tokenizerI2WHandle;

    public BlingTokenizer(string tokenizerBinPath, string tokenizerI2WPath)
    {
        _tokenizerBinPath = tokenizerBinPath;
        _tokenizerI2WPath = tokenizerI2WPath;
        _tokenizerBINHandle = 0;
        _tokenizerI2WHandle = 0;
    }

    public void LoadTokenizer1()
    {
        Debug.Log($"Loading tokenizer .bin file from {_tokenizerBinPath}");

        if (File.Exists(_tokenizerBinPath))
        {
            try
            {
                _tokenizerBINHandle = BlingFireUtils.LoadModel(_tokenizerBinPath);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("{0} Exception caught.", e);
                Debug.Log("Exception");
            }
        }
        else
        {
            Debug.Log("Tokenizer .bin file not found");
        }
    }

    public void LoadTokenizer2()
    {
        Debug.Log($"Loading tokenizer .i2w file from {_tokenizerI2WPath}");

        if (File.Exists(_tokenizerI2WPath))
        {
            try
            {
                _tokenizerI2WHandle = BlingFireUtils.LoadModel(_tokenizerI2WPath);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("{0} Exception caught.", e);
                Debug.Log("Exception");
            }
        }
        else
        {
            Debug.Log("Tokenizer .i2w file not found");
        }
    }

}
