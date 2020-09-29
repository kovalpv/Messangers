namespace Messengers.Vendors.Skype {
    public class ExceptionGenerator {
        private int connectCount = 0;
        private int connectionWithoutException = 3;

        public void ThrowIfConnectCountDivByWithoutExceptionIsEqualZero () {
            this.connectCount += 1;
            if (connectCount % connectionWithoutException == 0) {
                throw new ConnectionException ();
            }
        }
    }
}