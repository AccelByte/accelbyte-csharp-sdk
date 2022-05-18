// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core
{
    public abstract class StringEnum : IComparable
    {
        private readonly string _Value;

        public static object? NewValue(Type targetType,string value)
        {
            if (!typeof(StringEnum).IsAssignableFrom(targetType))
                throw new ArgumentException("Target type does not inherit from AbstractStringEnum");
            return Activator.CreateInstance(targetType, new object[] { value });
        }

        protected StringEnum()
        {
            _Value = String.Empty;
        }

        protected StringEnum(string value)
        {
            _Value = value;
        }

        public string Value { get => _Value; }

        public override string ToString()
        {
            return _Value;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            if (obj is StringEnum)
                return _Value.Equals((obj as StringEnum)!.Value);
            else
                return _Value.Equals(obj);
        }

        public override int GetHashCode()
        {
            return _Value.GetHashCode();
        }

        public int CompareTo(object? other)
        {
            if (other == null)
                return -1;

            if (other is StringEnum)
                return _Value.CompareTo((other as StringEnum)!.Value);
            else
                return _Value.CompareTo(other);
        }

        #region Operator Overloading
        public static bool operator ==(StringEnum a, StringEnum b)
        {
            if (a is null)
                return (b is null);
            return (a.Value == b.Value);
        }

        public static bool operator ==(StringEnum a, string b)
        {
            if (a is null)
                return (b is null);
            return (a.Value == b);
        }

        public static bool operator ==(string a, StringEnum b)
        {
            if (a is null)
                return (b is null);
            return (a == b.Value);
        }

        public static bool operator !=(StringEnum a, StringEnum b)
        {
            return (a.Value != b.Value);
        }

        public static bool operator !=(StringEnum a, string b)
        {
            return (a.Value == b);
        }

        public static bool operator !=(string a, StringEnum b)
        {
            return (a == b.Value);
        }
        #endregion
    }

    public abstract class StringEnum<T> : StringEnum where T : StringEnum
    {
        public static T NewValue(string value)
        {
            return (T)Activator.CreateInstance(typeof(T), new object[] { value })!;
        }

        public static List<T> NewValue(List<string> values)
        {
            List<T> list = new List<T>();
            foreach (string value in values)
                list.Add((T)Activator.CreateInstance(typeof(T), new object[] { value })!);
            return list;
        }

        public static List<T> operator |(StringEnum<T> a, StringEnum<T> b)
        {
            return new List<T>()
            {
                NewValue(a.Value),
                NewValue(b.Value)
            };
        }

        public static List<T> operator |(List<T> a, StringEnum<T> b)
        {
            a.Add(NewValue(b.Value));
            return a;
        }

        protected StringEnum(string value)
            : base(value)
        {

        }
    }
}