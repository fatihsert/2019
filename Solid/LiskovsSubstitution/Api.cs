using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LiskovsSubstitution
{
    public class Filter
    {

    }
    public abstract class ApiConnection
    {
        public abstract T[] ReadData<T>(Filter filter);
    }
    public class SimpleApiConnection : ApiConnection
    {
        public override T[] ReadData<T>(Filter filter)
        {
            //... gets data from api ...
            return null;
        }
    }

    public class TokenAuthApiConnection : SimpleApiConnection
    {
        private object authToken;
        private object authTokenFromApi;

        public virtual void GetAuthToken(string tokenUrl)
        {
            //    ... gets auth token...
            this.authToken = authTokenFromApi;
        }
        public override T[] ReadData<T>(Filter filter)
        {
            // ... get data using this.authToken...

            return null;
        }
    }

    public class LiskovApiTest
    {
        static void Test()
        {


        }
    }
}
