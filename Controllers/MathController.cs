
using Microsoft.AspNetCore.Mvc;
using Backend1.Models;
using Backend1.Services;

public class MathController : Controller
{
    private readonly IOperationService _operationService;

    public MathController(IOperationService operationService)
    {
        _operationService = operationService;
    }

    //ViewModel
    public IActionResult ViewModelExample()
    {
        int firstNumber = new Random().Next(0, 11);
        int secondNumber = new Random().Next(0, 11);

        var operationResult = new OperationResult
        {
            FirstNumber = firstNumber,
            SecondNumber = secondNumber,
            AddResult = _operationService.Add(firstNumber, secondNumber),
            SubtractResult = _operationService.Subtract(firstNumber, secondNumber),
            MultiplyResult = _operationService.Multiply(firstNumber, secondNumber),
            DivideResult = _operationService.Divide(firstNumber, secondNumber, out string errorMessage),
            ErrorMessage = errorMessage
        };

        return View("Index", operationResult);
    }

    //ViewData
    public IActionResult ViewDataExample()
    {
        int firstNumber = new Random().Next(0, 11);
        int secondNumber = new Random().Next(0, 11);

        string errorMessage;

        ViewData["FirstNumber"] = firstNumber;
        ViewData["SecondNumber"] = secondNumber;

        ViewData["AddResult"] = _operationService.Add(firstNumber, secondNumber);
        ViewData["SubtractResult"] = _operationService.Subtract(firstNumber, secondNumber);
        ViewData["MultiplyResult"] = _operationService.Multiply(firstNumber, secondNumber);
        ViewData["DivideResult"] = _operationService.Divide(firstNumber, secondNumber, out errorMessage);
        ViewData["ErrorMessage"] = errorMessage;

        return View("UsingViewData"); 
    }

    //ViewBag
    public IActionResult ViewBagExample()
    {
        int firstNumber = new Random().Next(0, 11);
        int secondNumber = new Random().Next(0, 11);

        string errorMessage;
        ViewBag.FirstNumber = firstNumber;
        ViewBag.SecondNumber = secondNumber;

        ViewBag.AddResult = _operationService.Add(firstNumber, secondNumber);
        ViewBag.SubtractResult = _operationService.Subtract(firstNumber, secondNumber);
        ViewBag.MultiplyResult = _operationService.Multiply(firstNumber, secondNumber);
        ViewBag.DivideResult = _operationService.Divide(firstNumber, secondNumber, out errorMessage);
        ViewBag.ErrorMessage = errorMessage;

        return View("UsingViewBag"); 
    }

    //Service Injection
    public IActionResult ServiceInjectionExample()
    {
        int firstNumber = new Random().Next(0, 11);
        int secondNumber = new Random().Next(0, 11);

        string errorMessage;
        var operationResult = new OperationResult
        {
            FirstNumber = firstNumber,
            SecondNumber = secondNumber,
            AddResult = _operationService.Add(firstNumber, secondNumber),
            SubtractResult = _operationService.Subtract(firstNumber, secondNumber),
            MultiplyResult = _operationService.Multiply(firstNumber, secondNumber),
            DivideResult = _operationService.Divide(firstNumber, secondNumber, out errorMessage),
            ErrorMessage = errorMessage
        };


        return View("UsingServiceInjection", operationResult);
    }
}

