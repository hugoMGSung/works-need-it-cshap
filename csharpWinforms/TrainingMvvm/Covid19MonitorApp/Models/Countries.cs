using System.Collections.Generic;

namespace Covid19MonitorApp.Models
{
    /// <summary>
    /// 국가별 정보 클래스
    /// </summary>
    public class Country
    {   
        public string name { get; set; }
        public string iso2 { get; set; }
        public string iso3 { get; set; }
    }

    public class Countries
    {
        public List<Country> countries { get; set; }
    }

    /**
     * 값이 json에 아래와 같이 들어있음. List 값도 소문자 countries로 동일 속성값도 name, iso2, iso3로 동일해야 함
     * Id = 15, Status = RanToCompletion, Method = "{null}", Result = "{\"countries\":[{\"name\":\"Afghanistan\",\"iso2\":\"AF\",
     **/ 
}
