//The task is to analyze all possible scenarios of relationship of two given circles. There is no assumption

//or limitation for range of values for x, y and radius (any integer value can be used).

namespace CircleApp
{
    partial struct Circle
    {
        int x;
        int y;
        int radix;

        //Setting values of the circle
        public Circle(int x, int y, int radix)
        {
            this.x = x;
            this.y = y;
            this.radix = radix;
        }

        //Method to perform the relation between the circles
        public static Relation CalculateRelation(Circle c1, Circle c2)
        {

            int distanceSq = (c1.x - c2.x) * (c1.x - c2.x) +
                     (c1.y - c2.y) * (c1.y - c2.y);
            int radiusSumSq = (c1.radix + c2.radix) * (c1.radix + c2.radix);
            if (distanceSq == radiusSumSq)
                return Relation.OneTangentPoint;

            else if (distanceSq > radiusSumSq)
                return Relation.NotTouched;

            else
                return Relation.TwoCrossingPoints;

        }

    }
}
