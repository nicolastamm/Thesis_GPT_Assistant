using System.IO;
using UnityEngine;

public class RunModel : MonoBehaviour
{
    private BlingTokenizer tokenizer = null;

    public string _modelPath = "F:/Thesis/Model/onnx/gpt2-10.onnx";

    public string _tokenizerBinPath = "F:/Thesis/Model/tokenizer/gpt2.bin";
    public string _tokenizerI2WPath = "F:/Thesis/Model/tokenizer/gpt2.i2w";


    void Start()
    {
        tokenizer = new BlingTokenizer(tokenizerBinPath:_tokenizerBinPath, tokenizerI2WPath:_tokenizerI2WPath);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            tokenizer.LoadTokenizer1();
        
        if (Input.GetKeyDown(KeyCode.S))
            tokenizer.LoadTokenizer2();    
    }
}
