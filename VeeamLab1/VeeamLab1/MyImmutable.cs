namespace VeeamLab1
{
    public sealed class MyImmutable
    {
        public int Number { get; }
        public string Caption { get; }

        public MyImmutable (int number, string caption)
        {
            Number = number;
            Caption = caption;
        }

        public MyImmutable Clone(int? number = null, string caption = null)
        {
            return new MyImmutable(
                number: number != null ? (int)number : Number,
                caption: caption ?? Caption
                );
        }

        public override string ToString()
        {
            return $"{Number} - {Caption}";
        }
    }
}
