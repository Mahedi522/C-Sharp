// namespace deligate
// {
//     public delegate void TestDelegate();
//     public delegate bool TestBoolDelegate(int i);
//     public delegate void TestDelegate1();
//     class deligateCMC
//     {
//         public TestDelegate testDelegateFunction;
//         public TestBoolDelegate testBoolDelegateFunction;

//         public TestDelegate1 testDelegateFunction1;
//         public Action testAction;
//         public Action<int, float> testIntFloatAction;

//         public Func<bool> testfunc;
//         public Func<int, bool> testIntBoolFunc;
        
//         public void start()
//         {
//             testDelegateFunction = MyTestDelegateFunction;
//             testDelegateFunction += MySecondTestDelegateFunction;
//             testDelegateFunction();

//             testBoolDelegateFunction = myTestBoolDelegateFunction;
//             System.Console.WriteLine(testBoolDelegateFunction(1));
//             //anonymous method
//             testDelegateFunction1 = delegate(){System.Console.WriteLine("anonymous method");};
//             testDelegateFunction1();
//             //lambda method
//             testDelegateFunction1 = () =>{System.Console.WriteLine("Lambda expression");};
//             testDelegateFunction1();

//             testBoolDelegateFunction = (int i) =>{return i<5;};
//             System.Console.WriteLine(testBoolDelegateFunction(6));
            
//             testAction = () => {System.Console.WriteLine("no argument action");};
//             testIntFloatAction = (int i, float f) => {System.Console.WriteLine("Action INt Float");};

//             testAction();
//             testIntFloatAction(3,5);

//             testfunc = () => false;
//             testIntBoolFunc = (int i) => {return i<5;};
//             System.Console.WriteLine(testIntBoolFunc(5));
//         }

//         public void MyTestDelegateFunction()
//         {
//             System.Console.WriteLine("MyTestDelegateFunction");
//         }
//         public void MySecondTestDelegateFunction()
//         {
//             System.Console.WriteLine("MySecondTestDelegateFunction");
//         }

//         public bool myTestBoolDelegateFunction(int i)
//         {
//             return i<5;
//         }

//     }
// }