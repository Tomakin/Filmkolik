import React from "react";
import { makeStyles } from "@material-ui/core/styles";
import GridList from "@material-ui/core/GridList";
import GridListTile from "@material-ui/core/GridListTile";
import GridListTileBar from "@material-ui/core/GridListTileBar";
import ListSubheader from "@material-ui/core/ListSubheader";
import IconButton from "@material-ui/core/IconButton";
import InfoIcon from "@material-ui/icons/Info";
import { tbdmInstancer } from "../_services/index";

const useStyles = makeStyles((theme) => ({
  root: {
    display: "flex",
    flexWrap: "wrap",
    justifyContent: "flex-start",
    overflow: "hidden",
  },
  gridList: {
    width: 500,
    height: 185,
  },
  icon: {
    color: "rgba(255, 255, 255, 0.54)",
  },
}));

export function FilmGridList({ films, ...props }) {
  const classes = useStyles();

  return (
    <div className={classes.root}>
      <GridList cellHeight={180} className={classes.gridList}>
        {films &&
          films.map((film) => (
            <GridListTile key={film.filmImageUrl}>
              <img
                src={tbdmInstancer.getImage(film.filmImageUrl)}
                alt={film.filmName}
              />
              <GridListTileBar
                title={film.filmName}
                actionIcon={
                  <IconButton
                    aria-label={`info about ${film.title}`}
                    className={classes.icon}
                  >
                    <InfoIcon />
                  </IconButton>
                }
              />
            </GridListTile>
          ))}
      </GridList>
    </div>
  );
}
