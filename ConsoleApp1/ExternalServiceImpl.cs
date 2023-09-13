namespace ConsoleApp1
{
    public class ExternalServiceImpl : IExternalService
    {
        private readonly IInteriorService? _service1;
        #region 正确期望输出
        //public ExternalServiceImpl(IInteriorService service1) : this()
        //{
        //    _service1 = service1;
        //    Console.WriteLine("ExternalServiceImpl(IParentService)");
        //}
        //public ExternalServiceImpl()
        //{
        //    Console.WriteLine("ExternalServiceImpl()");
        //}
        #endregion
        #region 错误期望输出
        public ExternalServiceImpl()
        {
            Console.WriteLine("ExternalServiceImpl()");
        }
        public ExternalServiceImpl(IInteriorService service1) : this()
        {
            _service1 = service1;
            Console.WriteLine("ExternalServiceImpl(IParentService)");
        }
        #endregion
        public void SayHello()
        {
            Console.WriteLine("Hello External!");
            _service1?.SayHello();
        }
    }
}