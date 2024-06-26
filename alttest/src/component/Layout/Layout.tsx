import React from "react";
import { Outlet } from "react-router-dom";
import Header from "./Header/Header";
const Layout: React.FC = () => {
    return (
        <>
            <header>
                <Header />
            </header>
            <main>
                <Outlet />
            </main>

        </>
    );
};

export default Layout;