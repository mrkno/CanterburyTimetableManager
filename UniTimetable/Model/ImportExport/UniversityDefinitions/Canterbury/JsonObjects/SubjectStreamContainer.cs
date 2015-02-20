﻿using System.Runtime.Serialization;

namespace UniTimetable.Model.ImportExport.UniversityDefinitions.Canterbury.JsonObjects
{
    [DataContract]
    public class SubjectStreamContainer
    {
        [DataMember]
        public string Key { get; set; }

        [DataMember]
        public SubjectStream Value { get; set; }
    }
}
