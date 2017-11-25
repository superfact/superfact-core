using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Data.Data.Configurations
{
    internal static class EntityTypeConfigurationExtensions
    {
        private const string Index = "Index";

        //public static PrimitivePropertyConfiguration HasIndex(
        //    this PrimitivePropertyConfiguration configuration,
        //    string indexName)
        //{
        //    return configuration.HasColumnAnnotation(
        //        Index,
        //        new IndexAnnotation(new IndexAttribute(indexName) { IsUnique = false }));
        //}

        //public static PrimitivePropertyConfiguration HasIndex(
        //    this PrimitivePropertyConfiguration configuration,
        //    string indexName,
        //    int order)
        //{
        //    return configuration.HasColumnAnnotation(
        //        Index,
        //        new IndexAnnotation(new IndexAttribute(indexName, order) { IsUnique = false }));
        //}

        //public static PrimitivePropertyConfiguration HasUniqueIndex(
        //    this PrimitivePropertyConfiguration configuration,
        //    string indexName)
        //{
        //    return configuration.HasColumnAnnotation(
        //        Index,
        //        new IndexAnnotation(new IndexAttribute(indexName) { IsUnique = true }));
        //}

        //public static PrimitivePropertyConfiguration HasUniqueIndex(
        //    this PrimitivePropertyConfiguration configuration,
        //    string indexName,
        //    int order)
        //{
        //    return configuration.HasColumnAnnotation(
        //        Index,
        //        new IndexAnnotation(new IndexAttribute(indexName, order) { IsUnique = true }));
        //}
    }
}
