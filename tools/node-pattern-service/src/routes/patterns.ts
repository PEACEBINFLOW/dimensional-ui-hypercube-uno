import { Router } from "express";
import { MotionPattern } from "../models/MotionPattern";

const patterns: Record<string, MotionPattern> = {};

const router = Router();

router.post("/", (req, res) => {
  const pattern = req.body as MotionPattern;
  if (!pattern.Id) {
    return res.status(400).json({ error: "Id is required" });
  }
  patterns[pattern.Id] = pattern;
  res.status(201).json({ ok: true });
});

router.get("/:id", (req, res) => {
  const p = patterns[req.params.id];
  if (!p) return res.status(404).json({ error: "Not found" });
  res.json(p);
});

router.get("/", (_req, res) => {
  res.json(Object.values(patterns));
});

export default router;
