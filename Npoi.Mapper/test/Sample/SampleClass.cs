﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npoi.Mapper.Attributes;

namespace test.Sample
{
    /// <summary>
    /// Sample class for testing purpose.
    /// </summary>
    public class SampleClass
    {
        public SampleClass()
        {
            CollectionGenericProperty = new List<string>();
            GeneralCollectionProperty = new List<string>();
        }

        public SampleClass(ICollection<string> collectionGenericProperty)
        {
            CollectionGenericProperty = collectionGenericProperty;
        }

        public string StringProperty { get; set; }

        public int Int32Property { get; set; }

        public bool BoolProperty { get; set; }

        public DateTime DateProperty { get; set; }

        public double DoubleProperty { get; set; }

        public SampleEnum EnumProperty { get; set; }

        public object ObjectProperty { get; set; }

        [Column(ResolverType = typeof(MultiColumnContainerResolver))]
        public ICollection<string> CollectionGenericProperty { get; set; }

        [Column(Index = 51, ResolverType = typeof(SingleColumnResolver))]
        public string SingleColumnResolverProperty { get; set; }

        [Column(Name = "By Name")]
        public string ColumnNameAttributeProperty { get; set; }

        [Column(Index = 11)]
        public string ColumnIndexAttributeProperty { get; set; }

        [Column(Index = 12, Name = "By Name")]
        public string IndexOverNameAttributeProperty { get; set; }

        [Column(UseLastNonBlankValue = true)]
        public string UseLastNonBlankValueAttributeProperty { get; set; }

        [Column(Ignored = true)]
        public string IgnoredAttributeProperty { get; set; }

        [Display(Name = "Display Name")]
        public string DisplayNameProperty { get; set; }

        public string GeneralProperty { get; set; }

        public ICollection<string> GeneralCollectionProperty { get; set; }

        [Column(BuiltinFormat = 0xf)]
        public DateTime BuiltinFormatProperty { get; set; }

        [Column(CustomFormat = "0%")]
        public double CustomFormatProperty { get; set; }
    }
}