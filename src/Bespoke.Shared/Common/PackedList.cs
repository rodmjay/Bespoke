namespace Bespoke.Shared.Common
{
    public class PackedList<T>
    {
        public IEnumerable<T> Data { get; set; }
        public int Total { get; set; }
    }
}