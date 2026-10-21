# Morning Pick

**Live app:** https://mangoomeh.github.io/morning-pick/

A phone-first workout planner and tracker. Each time you train, choose **Gym**, **Home**, **Run** or **Swim** and pick the session you want. Logging is quick.

- Your own gym and home routines (create, edit, reorder, delete), preloaded with full body, upper/lower and push/pull/legs templates
- Automatic progression: weights go up, bodyweight moves level up, and assisted machines need less assistance
- Prefilled sets, a rest timer, a plate calculator and exercise swaps; skip anything you don't tick
- Treadmill runs with speeds worked out from your 5K time, and 50 m pool swims whose send-off times get faster each cycle. Both are editable, and the app suggests the next session.
- History, a strength chart and 5K test times
- Custom exercises for gym and home
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
2. Push to `main`. The workflow publishes the site to https://mangoomeh.github.io/morning-pick/.
3. On your phone, open that address and install it:
   - **iPhone (Safari):** Share → Add to Home Screen.
   - **Android (Chrome):** menu → Install app.

When you change any file, bump `VERSION` in `sw.js` so installed copies pick up the update.
