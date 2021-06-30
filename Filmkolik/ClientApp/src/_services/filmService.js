import { instance } from "./index";

export const filmService = {
  getMovies,
};

function getMovies() {
  const resp = instance.get("/films").then(res => res);
  return resp;
}
