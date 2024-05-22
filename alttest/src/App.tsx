import React from 'react';
import logo from './logo.svg';
import './App.css';
import Layout from "./component/Layout/Layout";
import PATHS from "./data/paths";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom"
import Main from "./pages/Main/Main";
import Regress from "./pages/Regress/Regress";
import Spaces from "./pages/Spaces/Spaces";
import SignIn from "./pages/SignIn/SignIn";
import SignUp from "./pages/SignUp/SignUp";
import {colors, createTheme, ThemeProvider} from "@mui/material";

export default function App() {

    const theme = createTheme({
        palette: {
            primary: {
                main: colors.indigo[800],
            }
        },
    });

    return (
        <>
        <ThemeProvider theme={theme}>
            <Router>
                <Routes>
                    <Route path={PATHS.SIGNIN} element={<SignIn />} />
                    <Route path={PATHS.SIGNUP} element={<SignUp />} />
                    <Route path={PATHS.MAIN} element={<Layout />}>
                        <Route path="" element={<Main />} />
                        <Route path={PATHS.REGRESS} element={<Regress />} />
                        <Route path={PATHS.SPACES} element={<Spaces />} />
                    </Route>
                </Routes>
            </Router>
            </ThemeProvider>
        </>
    );
}
