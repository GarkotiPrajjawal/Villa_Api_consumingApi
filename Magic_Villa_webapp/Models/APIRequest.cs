using MagicVilla_Utilityone;
using static MagicVilla_Utilityone.SD;

namespace Magic_Villa_webapp.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
    }
}
