﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Orchard.Localization.Models {
    public struct TimeParts {

        public TimeParts(int hour, int minute, int second, int millisecond) {
            _hour = hour;
            _minute = minute;
            _second = second;
            _millisecond = millisecond;
        }

        private readonly int _hour;
        private readonly int _minute;
        private readonly int _second;
        private readonly int _millisecond;

        public int Hour {
            get {
                return _hour;
            }
        }

        public int Minute {
            get {
                return _minute;
            }
        }

        public int Second {
            get {
                return _second;
            }
        }

        public int Millisecond {
            get {
                return _millisecond;
            }
        }

        public DateTime ToDateTime() {
            return new DateTime(
                DateTime.MinValue.Year,
                DateTime.MinValue.Month,
                DateTime.MinValue.Day,
                _hour > 0 ? _hour : DateTime.MinValue.Hour,
                _minute > 0 ? _minute : DateTime.MinValue.Minute,
                _second > 0 ? _second : DateTime.MinValue.Second,
                _millisecond > 0 ? _millisecond : DateTime.MinValue.Millisecond
            );
        }

        public override string ToString() {
            return String.Format("{0}:{1}:{2}.{3}", _hour, _minute, _second, _millisecond);
        }
    }
}
