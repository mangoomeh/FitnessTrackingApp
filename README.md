# Morning Pick

A phone-first workout planner and tracker. Each morning you choose **Gym**, **Home**, **Run** or **Swim**, and the app gives you the next session in that plan and makes logging quick.

- A 4-day upper/lower strength rotation that Gym and Home share, with automatic weight and level progression
- Prefilled sets, a rest timer, a plate calculator, exercise swaps and a "short on time" mode
- A 12-session treadmill plan with speeds worked out from your 5K time
- A 10-session 50 m pool plan whose send-off times get faster each cycle
- History, a strength chart (estimated 1RM) and 5K test times
- Installable (PWA), works offline, Export/Import backup

## Stack

There's no build step and no dependencies. It's plain static files:

| File | Purpose |
|---|---|
| `index.html` | The whole app (HTML, CSS, JS) |
| `manifest.webmanifest` | Install metadata (name, icons, colours) |
| `sw.js` | Service worker that caches files for offline use |
| `icons/` | App icons |
| `.github/workflows/pages.yml` | Deploys to GitHub Pages on every push to `main` |

Data is kept in the browser's `localStorage` on each device. To move to a new phone, use **Plan → Backup → Export** and then **Import**.

## Run locally

```sh
python3 -m http.server 8000
# open http://localhost:8000
```

## Deploy (GitHub Pages)

1. In the repo on GitHub, open **Settings → Pages** and set **Source** to **GitHub Actions**.
2. Push to `main`. The workflow publishes the site to `https://<user>.github.io/<repo>/`.
3. On your phone, open that URL and install it:
   - **iPhone (Safari):** Share → Add to Home Screen.
   - **Android (Chrome):** menu → Install app.

When you change any file, bump `VERSION` in `sw.js` so installed copies pick up the update.
