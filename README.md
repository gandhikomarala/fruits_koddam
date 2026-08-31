# SLICE STORM — Mobile Arcade Slicing Game Platform

Slice Storm is an original, fast-paced arcade slicing game where players swipe to slice flying crystal fruit and cybernetic energy pods, trigger massive combo chains, avoid volatile hazards, and compete on global leaderboards.

---

## 🍉 Architecture Overview

```
SliceStorm/
├── UnityClient/            # Unity C# Client Architecture
│   └── Assets/Scripts/     # Core, Input, Blades, Sliceables, Hazards, PowerUps, Combos, UI, Audio
├── Backend/                # Python FastAPI Distributed Backend Services
│   ├── app/                # API Endpoints, Models, Repositories, Analytics, NVIDIA Gateway
│   └── tests/              # Pytest automated test matrix (180 tests)
├── Infrastructure/         # Docker Compose, PostgreSQL configurations
├── docs/                   # Architecture, Game Design, API & Deployment Specifications
├── scripts/                # Standalone demo runner & diagnostic probes
└── index.html              # Standalone Playable Web Edition
```

---

## 🚀 Quick Start

### 1. Run the Standalone Game Probe
```bash
python scripts/demo_run.py
```

### 2. Play the Slicing Game
Open `index.html` directly in your browser or serve with:
```bash
python -m http.server 8000
```

### 3. Run Backend Test Matrix
```bash
pytest Backend/tests/ -v
```
