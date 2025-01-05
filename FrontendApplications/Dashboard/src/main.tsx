import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.tsx'
import { createBrowserRouter, createRoutesFromElements, Route, RouterProvider } from 'react-router-dom'
import React from 'react'
import { SomePage } from './pages/SomePage.tsx'
import { AnotherPage } from './pages/AnotherPage.tsx'



const router = createBrowserRouter(
  createRoutesFromElements(
    <React.Fragment>
      <Route path="/dashboard" element={<App />} />
      <Route path="/dashboard/some-page" element={<SomePage />} />
      <Route path="/dashboard/another-page" element={<AnotherPage />} />
    </React.Fragment>
  ));

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <RouterProvider router={router} />
  </StrictMode>,
)
