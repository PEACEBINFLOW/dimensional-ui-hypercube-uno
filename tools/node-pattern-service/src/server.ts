import express from "express";
import patternsRouter from "./routes/patterns";

const app = express();
app.use(express.json());

app.use("/patterns", patternsRouter);

const port = process.env.PORT || 4000;
app.listen(port, () => {
  console.log(`Pattern service listening on port ${port}`);
});
