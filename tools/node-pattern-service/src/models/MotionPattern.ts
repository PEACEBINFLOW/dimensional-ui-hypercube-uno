export interface MotionSample {
  X: number;
  Y: number;
  TimestampMs: number;
  GestureType: number;
  ShapeMode: number;
  Theme: number;
}

export interface MotionPattern {
  Id: string;
  UserId?: string;
  Label?: string;
  Samples: MotionSample[];
}
