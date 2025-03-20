# Ensure the repository is up-to-date and prune any stale remote-tracking branches
git fetch --prune

# Switch to the main branch (or devin) so you're not on a branch to be deleted
git checkout main

# Loop through all local branches and delete those not named "main" or "devin"
for branch in $(git branch | sed 's/^[ *]*//'); do
  if [[ "$branch" != "main" && "$branch" != "devin" ]]; then
    echo "Deleting branch: $branch"
    git branch -D "$branch"
  fi
done
