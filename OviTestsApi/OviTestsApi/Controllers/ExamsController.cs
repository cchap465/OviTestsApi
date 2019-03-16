using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OviTestsApi.Controllers
{
    [RoutePrefix("api/exams")]
    public class ExamsController : ApiController
    {
        [HttpGet]
        [Route("{id}")]
        public Examination GetExam(int id)
        {
            if (id == 1)
            {
                return new Examination()
                {
                    Id = 1,
                    Name = "DrugExamination",
                    Evaluations = new List<Evaluation>()
                    {
                        new Evaluation()
                        {
                            Id = 1,
                            Name = "Hgn",
                            Checkbox = new List<Criteria>()
                            {
                                new Criteria()
                                {
                                    CheckboxName = "Lack of Smooth Pursuit",
                                    RightChecked = true,
                                    LeftChecked = false
                                },
                                new Criteria()
                                {
                                    CheckboxName = "Nystagmus At Max Deviation",
                                    RightChecked = true,
                                    LeftChecked = false
                                },
                                new Criteria()
                                {
                                    CheckboxName = "Nystagmus Prior to 45 Degrees",
                                        RightChecked = true,
                                    LeftChecked = false
                                },
                                new Criteria()
                                {
                                    CheckboxName = "Vertical Gaze Nystagmus",
                                    RightChecked = true,
                                    LeftChecked = false
                                }
                            },
                        },
                        new Evaluation()
                        {
                            Id = 1,
                            Name = "Ols",
                            Checkbox = new List<Criteria>()
                            {
                                new Criteria()
                                {
                                    CheckboxName = "Sways",
                                    RightChecked = true,
                                    LeftChecked = null
                                },
                                new Criteria()
                                {
                                    CheckboxName = "Raises arms more than 6 inches",
                                    RightChecked = true,
                                    LeftChecked = null
                                },
                                new Criteria()
                                {
                                    CheckboxName = "Hops",
                                        RightChecked = true,
                                    LeftChecked = null
                                },
                                new Criteria()
                                {
                                    CheckboxName = "Puts foot down",
                                    RightChecked = true,
                                    LeftChecked = null
                                },
                                new Criteria()
                                {
                                    CheckboxName = "Cannot do test",
                                    RightChecked = true,
                                    LeftChecked = null
                                }
                            },
                        }
                    }
                };
            }
            else
            {
                return new Examination();
            }
        }
    }

    public class Examination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Evaluation> Evaluations { get; set; }
    }

    public class Evaluation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Criteria> Checkbox { get; set; }
    }

    public class Criteria
    {
        public string CheckboxName { get; set; }
        public bool? LeftChecked { get; set; }
        public bool? RightChecked { get; set; }
    }
}
