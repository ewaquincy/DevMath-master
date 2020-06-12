using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath {
    public class DevMath {

        public static float Lerp(float a, float b, float t) {
            return a + (b - a) * Clamp01(t);
        }

        public static float DistanceTraveled(float startVelocity, float acceleration, float time) {
            return startVelocity * time + 0.5f * acceleration * time * time;
        }

        public static float Clamp(float value, float min, float max) {
            if (value < min)
                value = min;
            else if (value > max)
                value = max;
            return value;
        }

        public static float Clamp01(float value) {
            if (value < 0.0)
                return 0.0f;
            if (value > 1.0)
                return 1f;
            return value;
        }

        public static float RadToDeg(float angle) {
            return angle * 57.29578f;
        }

        public static float DegToRad(float angle) {
            return angle * 0.0174532924f;
        }
    }
}