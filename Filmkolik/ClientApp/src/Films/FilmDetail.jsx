import React, { useEffect, useState } from "react";
import { tmdbInstancer } from "../_services/index";
import Container from "@material-ui/core/Container";
import Box from "@material-ui/core/Box";
import Paper from "@material-ui/core/Paper";
import { makeStyles } from "@material-ui/core/styles";
import Color from "color";
import Grid from "@material-ui/core/Grid";
import Typography from "@material-ui/core/Typography";

const useStyles = makeStyles((theme) => ({
  paperBgColor: {
    backgroundColor: Color("rgba(26, 25, 23, 0)").alpha(0.7).string(),
  },
  movieName: {
    ...theme.typography.button,
    fontSize: "40px",
    textAlign: "center",
    color: Color("rgb(255, 255, 255)").string(),
  },
  overview: {
    color: Color("rgb(255, 255, 255)").string(),
  },
  tagLine: {
    fontSize: "24px",
    color: theme.palette.primary.light,
  },
  genre: {
    color: theme.palette.primary.light,
    fontSize: "24px",
  },
  prodComps: {
    color: Color("rgb(255, 255, 255)").string(),
  },
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
          <Grid container>
            <Grid xs={3}>
              <Box
                component="img"
                maxHeight="500px"
                maxWidth="100%"
                alt="The house from the offer."
                src={tmdbInstancer.getLittleImage(film.poster_path)}
              />
            </Grid>
            <Grid md={9}>
              <Typography className={classes.movieName}>
                {film.original_title}
              </Typography>
              <Box px={3}>
                <Typography className={classes.tagLine}>
                  {film.tagline}
                </Typography>
              </Box>
              <Box px={3}>
                <Typography className={classes.overview}>
                  {film.overview}
                </Typography>
              </Box>
              <Box p={3}>
                <Typography className={classes.genre}>
                  {film.genres && film.genres.map((genre) => genre.name).join(', ')}
                </Typography>
              </Box>
              <Box px={3}>
                <Typography className={classes.prodComps}>
                  {film.production_companies &&
                    film.production_companies
                      .map((comp) => comp.name)
                      .join(", ")}
                </Typography>
              </Box>
            </Grid>
          </Grid>
        </Paper>
      </Container>
    </div>
  );
}

export { FilmDetail };
