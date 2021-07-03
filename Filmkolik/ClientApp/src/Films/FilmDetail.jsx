import React, { useEffect, useState } from "react";
import { tmdbInstancer } from "../_services/index";
import Container from "@material-ui/core/Container";
import Box from "@material-ui/core/Box";
import Paper from "@material-ui/core/Paper";
import { makeStyles } from "@material-ui/core/styles";
import Color from "color";
import Grid from '@material-ui/core/Grid';

const useStyles = makeStyles((theme) => ({
  paperBgColor: {
    backgroundColor: Color("rgba(26, 25, 23, 0)").alpha(0.7).string(),
  },
  movieName: {
    fontSize: "40px",
  },
  overview: {},
}));

function FilmDetail(props) {
  const Id = props.location.state.Id;
  const [film, setFilm] = useState({});
  const [credits, setCredits] = useState({});

  const classes = useStyles();

  useEffect(() => {
    tmdbInstancer.getMovie(Id).then((f) => {
      setFilm(f.data);
    });
    tmdbInstancer.getCredits(Id).then((c) => {
      setCredits(c.data);
    });
  }, []);

  if (film.backdrop_path && document.getElementById("main")) {
    var main = document.getElementById("main");
    main.style.backgroundImage = `url(${tmdbInstancer.getOriginalImage(
      film.backdrop_path
    )})`;
    main.style.backgroundSize = "cover";
    main.style.backgroundPosition = "top center";
  }

  if (credits.cast) {
    var actors = credits.cast
      .filter((obj) => obj.known_for_department === "Acting")
      .slice(0, 5);
  }

  return (
    <div>
      <Container>
        <Paper className={classes.paperBgColor}>
          <Box
            component="img"
            maxHeight="500px"
            maxWidth="350px"
            alt="The house from the offer."
            src={tmdbInstancer.getLittleImage(film.poster_path)}
          />
          
        </Paper>
      </Container>
    </div>
  );
}

export { FilmDetail };
