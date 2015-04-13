

using System;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public class AccountMetadataAttribute : Attribute
{
    public string AccountDescription { get; set; }

    public string AccountLimitations { get; set; }
}


[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true, Inherited = true)]

public class FormatRestrictionAttribute : Attribute
{
    public string FormatString { get; set; }
    public int MaxLength { get; set; }


}