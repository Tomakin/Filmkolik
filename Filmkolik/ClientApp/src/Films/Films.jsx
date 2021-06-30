import React, { useEffect, useState } from "react";
import { tbdmInstancer } from "../_services/index";
import { filmService } from "../_services/index";
import { FilmGridList } from "../FilmGridList/index";

export function Films() {
  const [films, setfilms] = useState([]);

  console.log(films);

  useEffect(() => {
    filmService.getMovies().then((res) => {
      console.log(res);
      setfilms(res.data);
    });
  }, []);

  return (
    <div>
      Filmler
      <FilmGridList films={films} />
    </div>
  );
}
