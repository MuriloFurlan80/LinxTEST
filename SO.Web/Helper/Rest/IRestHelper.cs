using RestSharp;

namespace SO.Web.Helper.Rest
{
    public interface IRestHelper
    {
        IRestResponse<T> Get<T>(string path);
        IRestResponse<T> Post<T>(string path, object request);
    }
}
