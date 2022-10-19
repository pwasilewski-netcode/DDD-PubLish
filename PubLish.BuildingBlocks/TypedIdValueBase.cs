using System;

namespace PubLish.BuildingBlocks
{
    public abstract class TypedIdValueBase : IEquatable<TypedIdValueBase>
    {
        public Guid Value { get; }

        protected TypedIdValueBase(Guid value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is TypedIdValueBase other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public bool Equals(TypedIdValueBase other) => Value == other!.Value;

        public override string ToString() => Value.ToString();

        public static bool operator ==(TypedIdValueBase obj1, TypedIdValueBase obj2)
        {
            return obj1?.Equals(obj2) ?? Equals(obj2, null);
        }

        public static bool operator !=(TypedIdValueBase x, TypedIdValueBase y) => !(x == y);

        public static implicit operator Guid(TypedIdValueBase id) => id.Value;

        public static implicit operator string(TypedIdValueBase id) => id.ToString();
    }
}