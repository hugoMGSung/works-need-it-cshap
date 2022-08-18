﻿using System;

namespace WpfExamples
{
    public class ExampleAttribute : Attribute
    {
        public ExampleAttribute(string description)
            : this(null, description)
        {
        }

        public ExampleAttribute(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }

        public string Title { get; private set; }

        public string Description { get; private set; }
    }
}
